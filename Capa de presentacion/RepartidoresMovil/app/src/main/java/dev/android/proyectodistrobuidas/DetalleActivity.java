package dev.android.proyectodistrobuidas;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import dev.android.proyectodistrobuidas.Adapter.AdapterDetalle;
import dev.android.proyectodistrobuidas.Clases.DetallePedido;
import dev.android.proyectodistrobuidas.Clases.GlobalVariable;

public class DetalleActivity extends AppCompatActivity {

    RequestQueue queue;
    TextView cliente, direccion, total, idUserD;
    RecyclerView recyclerView;
    List<DetallePedido> lista;
    String clienteExtra="", direccionExtra="", totalExtra="", idExtra="";
    String idUserExtra="";
    Button escogerPedido, confirmarPedido;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalle);
        recyclerView = findViewById(R.id.rvDetallePedido);

        escogerPedido = findViewById(R.id.btnEscogerPedido);
        confirmarPedido = findViewById(R.id.btnConfirmarPedido);

        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        cliente = findViewById(R.id.txtDetalleCliente);
        direccion=findViewById(R.id.txtDetalleDireccion);
        total =findViewById(R.id.txtDetallePrecio);
        idUserD = findViewById(R.id.txtIdUserDetalle);

        lista = new ArrayList<>();

        Bundle extras = getIntent().getExtras();
        if(extras!=null){
            clienteExtra = extras.getString("cliente");
            direccionExtra=extras.getString("direccion");
            totalExtra=extras.getString("total");
            idExtra=extras.getString("id");
            //idUserExtra = extras.getString("u");

        }

        cliente.setText(clienteExtra);
        direccion.setText(direccionExtra);
        total.setText(totalExtra);

        idUserD.setText(GlobalVariable.username);

        cargarDetallePedido("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/cargarPedidosDetalle?pedido="+idExtra+"");
        //cargarDetallePedido("http://proyectodistro.somee.com/Pedidos.svc/cargarDetallePedido?pedido="+idExtra+"");


    }

    private void actualizarEstadoPedido(String URL) {
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {

                    if(!response.isEmpty()){

                    }else{

                    }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(DetalleActivity.this, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue queue = Volley.newRequestQueue(this);
        queue.add(stringRequest);
    }

    private void asignarRepartidor(String URL) {
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {

                if(!response.isEmpty()){

                }else{

                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(DetalleActivity.this, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue queue = Volley.newRequestQueue(this);
        queue.add(stringRequest);
    }

    private void cargarDetallePedido(String URL) {
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                Toast.makeText(getApplicationContext(),"cargando", Toast.LENGTH_SHORT).show();

                try {
                    JSONArray array = new JSONArray(response);
                    for (int i = 0; i < array.length(); i++) {
                        JSONObject jsonObject = array.getJSONObject(i);

                        lista.add(new DetallePedido(
                                jsonObject.getString("NombreProducto"),
                                jsonObject.getString("Cantidad"),
                                jsonObject.getString("PrecioProducto")));
                    }

                    AdapterDetalle adapter = new AdapterDetalle(DetalleActivity.this, lista);
                    recyclerView.setAdapter(adapter);
                    onResume();

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
        getMenuInflater().inflate(R.menu.menu_superior, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        if(id == R.id.btnConfirmarPedido){
            actualizarEstadoPedido("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/ActualizarEstadoPedido?estado=e&pedido="+idExtra+"");
            Toast.makeText(DetalleActivity.this, "Pedido Entregado!", Toast.LENGTH_SHORT).show();
            this.finish();
        }else if(id == R.id.btnEscogerPedido){

            actualizarEstadoPedido("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/ActualizarEstadoPedido?estado=p&pedido="+idExtra+"");
            asignarRepartidor("http://proyectofinal.somee.com/proyectoFinal/Pedidos.svc/AsignarRepartidor?repartidor="+idUserD.getText()+"&pedido="+idExtra+"");
            Toast.makeText(DetalleActivity.this, "Pedido Seleccionado!", Toast.LENGTH_SHORT).show();
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    protected void onResume() {
        super.onResume();
        AdapterDetalle adapter = new AdapterDetalle(DetalleActivity.this, lista);
        recyclerView.setAdapter(adapter);
    }




}