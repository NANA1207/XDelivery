package dev.android.proyectodistrobuidas;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ImageView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import dev.android.proyectodistrobuidas.Adapter.Adapter;
import dev.android.proyectodistrobuidas.Adapter.AdapterDetalle;
import dev.android.proyectodistrobuidas.Clases.Pedido;

public class MainActivity extends AppCompatActivity {

    RecyclerView res;
    List<Pedido> lista;

    String idExtra="";
    ImageView imagen;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        res = findViewById(R.id.rvProductosCliente);

        res.setHasFixedSize(true);
        res.setLayoutManager(new LinearLayoutManager(this));


        lista = new ArrayList<>();

        imagen = (ImageView) findViewById(R.id.imageView);

        Bundle extras = getIntent().getExtras();
        if(extras!=null){
            idExtra=extras.getString("user");
        }

        cargarPedidos("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/cargarPedidosPorEstado?estado=na");

       // abrirDetalle();
    }

    private void cargarPedidos(String URL) {
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                Toast.makeText(getApplicationContext(),"cargando", Toast.LENGTH_SHORT).show();

                try {
                    JSONArray array = new JSONArray(response);
                    for (int i = 0; i < array.length(); i++) {
                        JSONObject jsonObject = array.getJSONObject(i);

                        lista.add(new Pedido(
                                jsonObject.getString("Direccion"),
                                jsonObject.getString("EstadoPedido"),
                                jsonObject.getString("FechaPedido"),
                                jsonObject.getString("IdClientePedido"),
                                jsonObject.getString("IdPedido"),
                                jsonObject.getString("IdRepartidorPedido"),
                                jsonObject.getString("TotalPedido"),
                                jsonObject.getString("NombreC"),
                                jsonObject.getString("NombreR")));

                    }

                    Adapter adapter = new Adapter(MainActivity.this, lista);
                    adapter.notifyDataSetChanged();

                    res.setAdapter(adapter);



                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(getApplicationContext(), error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        Volley.newRequestQueue(this).add(stringRequest);
        //queue.add(stringRequest);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_login, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        if(id == R.id.opSalir){
            this.finish();
        }else if(id == R.id.opActualizar){
            onResume();
        }else if(id == R.id.opMisPedidos){
            Intent i = new Intent(this,MisPedidosActivity.class);
            startActivity(i);
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onResume() {
        super.onResume();
        Adapter adapter = new Adapter(MainActivity.this, lista);
        res.setAdapter(adapter);
    }
}