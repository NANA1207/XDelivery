package dev.android.proyectodistrobuidas.Adapter;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

import dev.android.proyectodistrobuidas.Clases.Pedido;
import dev.android.proyectodistrobuidas.DetalleActivity;
import dev.android.proyectodistrobuidas.R;

public class Adapter extends RecyclerView.Adapter<Adapter.ViewHolder>{

    Context context;
    List<Pedido> lista;


    public Adapter(Context context, List<Pedido> lista) {
        this.context = context;
        this.lista = lista;
    }

    public Adapter.ViewHolder onCreateViewHolder(ViewGroup viewGroup, int viewType) {
        LayoutInflater inflater= LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.fila_personalizada, null);

        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(Adapter.ViewHolder holder, int position) {

        Pedido pedido = lista.get(position);

        holder.cliente.setText(pedido.getNombreC());
        holder.total.setText("$"+pedido.getTotalPedido());
        holder.fecha.setText(pedido.getDireccion());
        holder.ID.setText(pedido.getIdPedido());
        //holder.u.getText();
        holder.setOnClickListeners();
    }

    @Override
    public int getItemCount() {
        return lista.size();
    }


    public static class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener {
        TextView cliente, total, fecha,ID, u;
        Context context;
        ImageView imagen;


        public ViewHolder(View itemView) {
            super(itemView);
            context = itemView.getContext();
            cliente = itemView.findViewById(R.id.txtPedidoCliente);
            total = itemView.findViewById(R.id.txtPedidoTotal);
            fecha = itemView.findViewById(R.id.txtPedidoFecha);
            ID = itemView.findViewById(R.id.txtPedidoID);
            imagen = itemView.findViewById(R.id.imageView);
            //u = itemView.findViewById(R.id.txtUsuario);
        }

        public void setOnClickListeners() {
            imagen.setOnClickListener(this);
        }

        @Override
        public void onClick(View v) {
            switch (v.getId()){
                case R.id.imageView:
                    Intent intent = new Intent(context, DetalleActivity.class);
                    intent.putExtra("cliente",cliente.getText());
                    intent.putExtra("direccion", fecha.getText());
                    intent.putExtra("total",total.getText());
                    intent.putExtra("id", ID.getText());
                    //intent.putExtra("u", u.getText());
                    context.startActivity(intent);
                    break;
            }
        }
    }
}
