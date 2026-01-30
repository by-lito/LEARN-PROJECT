package ejercicios;

import android.os.Bundle;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity; // Importamos la librería Glide import com.bumptech.glide.Glide;

import com.bumptech.glide.Glide;
import com.example.multimedia.R;

public class Ej112 extends AppCompatActivity {

    private final String URL_IMAGEN = "https://imgs.search.brave.com/rYjjPABzIMCG6yknSP0ybAkcK5Aax5jM_VL2frr33SM/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS50ZW5vci5jb20v/NUxCN1o3VENBSnNB/QUFBTS9jdXRlLWxp/dHRsZS1raXR0eS1i/eS1mcjR1ZC5naWY.gif";
    ImageView iv;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_112);

        iv = findViewById(R.id.ivPanoramica);
        cargarImagenDesdeUrl();
    }
        private void cargarImagenDesdeUrl()
        {
            // Glide gestiona la descarga en segundo plano automáticamente.
            // Si intentáramos descargarla con código nativo en el hilo principal,
            // la aplicación se cerraría(NetworkOnMainThreadException).
            Glide.with(this).load(URL_IMAGEN).placeholder(android.R.drawable.ic_menu_gallery).error(android.R.drawable.stat_notify_error).fitCenter().into(iv);
        // Equivalente a fit().centerInside() .into(ivImagen);
            // Notificamos al usuario que el proceso ha iniciado
            Toast.makeText(this, "Cargando panorámica...", Toast.LENGTH_SHORT).show();
        }
    }
