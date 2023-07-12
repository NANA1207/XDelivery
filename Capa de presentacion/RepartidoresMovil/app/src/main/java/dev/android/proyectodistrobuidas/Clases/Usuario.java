package dev.android.proyectodistrobuidas.Clases;

public class Usuario {
    String Username;
    String Contrasena;

    String IdUsuario;
    String Nombre, Apellido, EstadoUsuario, TipoUsuario;

    public Usuario(String username, String contrasena, String idUsuario, String nombre, String apellido, String estadoUsuario, String tipoUsuario) {
        Username = username;
        Contrasena = contrasena;
        IdUsuario = idUsuario;
        Nombre = nombre;
        Apellido = apellido;
        EstadoUsuario = estadoUsuario;
        TipoUsuario = tipoUsuario;
    }


    public String getUsername() {
        return Username;
    }

    public void setUsername(String username) {
        Username = username;
    }

    public String getContrasena() {
        return Contrasena;
    }

    public void setContrasena(String contrasena) {
        Contrasena = contrasena;
    }

    public String getIdUsuario() {
        return IdUsuario;
    }

    public void setIdUsuario(String idUsuario) {
        IdUsuario = idUsuario;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String apellido) {
        Apellido = apellido;
    }

    public String getEstadoUsuario() {
        return EstadoUsuario;
    }

    public void setEstadoUsuario(String estadoUsuario) {
        EstadoUsuario = estadoUsuario;
    }

    public String getTipoUsuario() {
        return TipoUsuario;
    }

    public void setTipoUsuario(String tipoUsuario) {
        TipoUsuario = tipoUsuario;
    }

    public Usuario() {
    }


}
