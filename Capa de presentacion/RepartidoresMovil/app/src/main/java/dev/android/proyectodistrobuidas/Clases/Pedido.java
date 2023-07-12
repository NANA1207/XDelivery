package dev.android.proyectodistrobuidas.Clases;

public class Pedido {
    public Pedido(String direccion, String estadoPedido, String fechaPedido, String idClientePedido, String idPedido, String idRepartidorPedido, String totalPedido, String nombreC, String nombreR) {
        Direccion = direccion;
        EstadoPedido = estadoPedido;
        FechaPedido = fechaPedido;
        IdClientePedido = idClientePedido;
        IdPedido = idPedido;
        IdRepartidorPedido = idRepartidorPedido;
        TotalPedido = totalPedido;
        NombreC = nombreC;
        NombreR = nombreR;
    }

    public Pedido() {
    }

    public String getDireccion() {
        return Direccion;
    }

    public void setDireccion(String direccion) {
        Direccion = direccion;
    }

    public String getEstadoPedido() {
        return EstadoPedido;
    }

    public void setEstadoPedido(String estadoPedido) {
        EstadoPedido = estadoPedido;
    }

    public String getFechaPedido() {
        return FechaPedido;
    }

    public void setFechaPedido(String fechaPedido) {
        FechaPedido = fechaPedido;
    }

    public String getIdClientePedido() {
        return IdClientePedido;
    }

    public void setIdClientePedido(String idClientePedido) {
        IdClientePedido = idClientePedido;
    }

    public String getIdPedido() {
        return IdPedido;
    }

    public void setIdPedido(String idPedido) {
        IdPedido = idPedido;
    }

    public String getIdRepartidorPedido() {
        return IdRepartidorPedido;
    }

    public void setIdRepartidorPedido(String idRepartidorPedido) {
        IdRepartidorPedido = idRepartidorPedido;
    }

    public String getTotalPedido() {
        return TotalPedido;
    }

    public void setTotalPedido(String totalPedido) {
        TotalPedido = totalPedido;
    }

    public String getNombreC() {
        return NombreC;
    }

    public void setNombreC(String nombreC) {
        NombreC = nombreC;
    }

    public String getNombreR() {
        return NombreR;
    }

    public void setNombreR(String nombreR) {
        NombreR = nombreR;
    }

    String Direccion, EstadoPedido,FechaPedido,IdClientePedido,IdPedido,IdRepartidorPedido, TotalPedido, NombreC, NombreR;
}
