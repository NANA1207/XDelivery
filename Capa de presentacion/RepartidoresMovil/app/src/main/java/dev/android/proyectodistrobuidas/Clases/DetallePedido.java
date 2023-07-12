package dev.android.proyectodistrobuidas.Clases;

public class DetallePedido {
    String producto;
    String cantidad;
    Boolean estado=false;
    String precio;

    public DetallePedido(String producto, String cantidad, String precio) {
        this.producto = producto;
        this.cantidad = cantidad;
        this.precio=precio;

    }

    public DetallePedido(){}

    public String getProducto() {
        return producto;
    }

    public void setProducto(String producto) {
        this.producto = producto;
    }

    public String getCantidad() {
        return cantidad;
    }

    public void setCantidad(String cantidad) {
        this.cantidad = cantidad;
    }

    public Boolean getEstado() {
        return estado;
    }

    public void setEstado(Boolean estado) {
        this.estado = estado;
    }

    public String getPrecio() {
        return precio;
    }

    public void setPrecio(String precio) {
        this.precio = precio;
    }
}
