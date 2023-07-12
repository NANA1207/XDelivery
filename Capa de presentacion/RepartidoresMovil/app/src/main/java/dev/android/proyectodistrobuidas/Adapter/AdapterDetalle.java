package dev.android.proyectodistrobuidas.Adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;

import androidx.recyclerview.widget.RecyclerView;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.util.List;

import dev.android.proyectodistrobuidas.Clases.DetallePedido;
import dev.android.proyectodistrobuidas.R;

public class AdapterDetalle extends RecyclerView.Adapter<AdapterDetalle.ViewHolder> {


    Context context;
    List<DetallePedido> lista;


    public AdapterDetalle(Context context, List<DetallePedido> lista) {
        this.context = context;
        this.lista = lista;
    }

    public AdapterDetalle.ViewHolder onCreateViewHolder(ViewGroup viewGroup, int viewType) {
        LayoutInflater inflater= LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.fila_pedidos, null);

        return new AdapterDetalle.ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(AdapterDetalle.ViewHolder holder, int position) {

        DetallePedido detallePedido = lista.get(position);

        holder.producto.setText(detallePedido.getProducto());
        holder.cantidad.setText(detallePedido.getCantidad());
        holder.precio.setText(detallePedido.getPrecio());
        /*holder.checkBox.setSelected(detallePedido.getEstado());
        holder.checkBox.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(holder.checkBox.isSelected()==detallePedido.getEstado()){
                    holder.checkBox.setSelected(true);
                    holder.servicio();
                }else{
                    holder.checkBox.setSelected(false);
                    holder.servicio();
                }


            }
        });

         */



    }

    @Override
    public int getItemCount() {
        return lista.size();
    }


    public static class ViewHolder extends RecyclerView.ViewHolder {
        TextView producto, cantidad, precio;
        Context context;
        CheckBox checkBox;

        public ViewHolder(View itemView) {
            super(itemView);
            context = itemView.getContext();
            producto = itemView.findViewById(R.id.txtNombreProducto);
            cantidad=itemView.findViewById(R.id.txtCantidadPedido);
            precio = itemView.findViewById(R.id.txtPrecioDetalleP);
            //checkBox = itemView.findViewById(R.id.cbxEstado);

        }

        private void servicio(){
            actualizarEstadoPedido("http://www.proyectodistro.somee.com/Pedidos.svc/actualizarEstadoProducto?estado="+checkBox.isSelected()+"&pedido=1&producto=5");
        }

        public void actualizarEstadoPedido(String URL) {
            StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
                @Override
                public void onResponse(String response) {

                    if(response.equalsIgnoreCase("true")){
                        Toast.makeText(context, "Pedido Seleccionado!", Toast.LENGTH_SHORT).show();
                    }else if(response.equalsIgnoreCase("false")){
                        Toast.makeText(context, "QUITADO!", Toast.LENGTH_SHORT).show();
                    }

                }
            }, new Response.ErrorListener() {
                @Override
                public void onErrorResponse(VolleyError error) {

                }
            });

            RequestQueue queue = Volley.newRequestQueue(context.getApplicationContext());
            queue.add(stringRequest);
        }
/*
        @Override
        public void onClick(View v) {
            switch (v.getId()){
                case R.id.imageView:
                    Intent intent = new Intent(context, DetalleActivity.class);
                    context.startActivity(intent);
                    break;
            }
        }

 */
    }


}
