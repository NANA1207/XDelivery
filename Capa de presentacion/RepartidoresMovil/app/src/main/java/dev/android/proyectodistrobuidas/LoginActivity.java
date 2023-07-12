package dev.android.proyectodistrobuidas;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
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

import org.json.JSONException;
import org.json.JSONObject;

import dev.android.proyectodistrobuidas.Clases.GlobalVariable;

public class LoginActivity extends AppCompatActivity {

    Button btnLogin;
    TextView usuario, contraseña;

    TextView idUser;
    RequestQueue queue;
    String id="";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        btnLogin = findViewById(R.id.btnIngresar);
        usuario = findViewById(R.id.txtUsuario);
        contraseña = findViewById(R.id.txtClave);


        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                validarUsuario("http://proyectofinal.somee.com/proyectoFinal/Usuarios.svc/validarUsuario?user="+usuario.getText()+ "&clave="+contraseña.getText()+"");
            }
        });

    }

    private void infoUser(String URL) {
        StringRequest jsonArrayRequest = new StringRequest(Request.Method.GET,URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                try {

                    JSONObject jsonResponse = new JSONObject(response);
                    id = jsonResponse.getString("IdUsuario");

                    Toast.makeText(getApplicationContext(), "Id" + id, Toast.LENGTH_SHORT).show();


                } catch (JSONException e) {
                    Toast.makeText(getApplicationContext(), e.toString(), Toast.LENGTH_SHORT).show();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(getApplicationContext(), error.toString(), Toast.LENGTH_SHORT).show();
            }
        });
        queue = Volley.newRequestQueue(this);
        queue.add(jsonArrayRequest);

    }

    private void validarUsuario(String URL){
        StringRequest stringRequest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                try{

                if(!response.isEmpty()){
                    Intent intent = new Intent(getApplicationContext(), MainActivity.class);

                    JSONObject jsonResponse = new JSONObject(response);
                    id = jsonResponse.getString("IdUsuario");
                    String tipo = jsonResponse.getString("TipoUsuario");
                    String estado = jsonResponse.getString("EstadoUsuario");

                    if(tipo.equals("R") && estado.equals("H")){
                        intent.putExtra("idUsuario",id);
                        intent.putExtra("user",usuario.getText().toString());
                        GlobalVariable.username=id;
                        startActivity(intent);
                    }else{
                        Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta!", Toast.LENGTH_SHORT).show();
                    }

                }else{
                    Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta!", Toast.LENGTH_SHORT).show();
                }
                }catch (JSONException e){

                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(LoginActivity.this, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue queue = Volley.newRequestQueue(this);
        queue.add(stringRequest);
    }



}
