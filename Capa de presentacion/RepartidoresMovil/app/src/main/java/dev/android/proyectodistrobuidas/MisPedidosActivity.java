package dev.android.proyectodistrobuidas;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
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
import dev.android.proyectodistrobuidas.Clases.GlobalVariable;
import dev.android.proyectodistrobuidas.Clases.Pedido;

public class MisPedidosActivity extends AppCompatActivity {

    RecyclerView res;
    List<Pedido> lista;

    String idRepartidor="";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mis_pedidos);

        res = findViewById(R.id.rvMisPedidos);

        res.setHasFixedSize(true);
        res.setLayoutManager(new LinearLayoutManager(this));


        lista = new ArrayList<>();
        idRepartidor= GlobalVariable.username;

        cargarPedidos("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/cargarPedidosPorRepartidor?repartidor="+idRepartidor+"");

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

                    Adapter adapter = new Adapter(MisPedidosActivity.this, lista);
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



}