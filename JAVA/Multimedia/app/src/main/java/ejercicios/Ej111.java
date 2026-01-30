package ejercicios;

import android.os.Bundle;
import android.util.DisplayMetrics;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.multimedia.R;

public class Ej111 extends AppCompatActivity {

    TextView tvInfo;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_111);

// 1. Inicializamos los componentes de la interfaz
        tvInfo = findViewById(R.id.tvInfoResolucion);
// 2. Llamamos al método que realiza el cálculo
        mostrarResolucionPantalla();
    }
    /**
     * Método para obtener y mostrar las métricas de la pantalla.
     * Basado en el uso de DisplayMetrics (Tema 11).
     */
    private void mostrarResolucionPantalla() {
// Creamos el objeto DisplayMetrics que contendrá la información
        DisplayMetrics metrics = new DisplayMetrics();
// Obtenemos el "WindowManager" predeterminado y volcamos los datos en 'metrics'
// getWindowManager() recupera el gestor de ventanas de la actividad
// getDefaultDisplay() obtiene la pantalla principal
// getMetrics(metrics) rellena el objeto con los datos reales
        getWindowManager().getDefaultDisplay().getMetrics(metrics);
// 3. Extraemos los datos de interés del objeto metrics
        int anchoPixeles = metrics.widthPixels; // Ancho absoluto en píxeles
        int altoPixeles = metrics.heightPixels; // Alto absoluto en píxeles
// Opcional pero recomendado en el tema: Obtener la densidad
        float densidadLogica = metrics.density; // Factor de escala (0.75, 1.0, 2.0, etc.)
        int densidadDpi = metrics.densityDpi; // Píxeles por pulgada (160, 320, 480, etc.)
// 4. Construimos el mensaje de salida
        StringBuilder mensaje = new StringBuilder();
        mensaje.append("RESOLUCIÓN DETECTADA:\n");
        mensaje.append("---------------------\n");
        mensaje.append("Ancho: ").append(anchoPixeles).append(" px\n");
        mensaje.append("Alto: ").append(altoPixeles).append(" px\n\n");
        mensaje.append("DATOS DE DENSIDAD:\n");
        mensaje.append("Densidad (DPI): ").append(densidadDpi).append(" dpi\n");
        mensaje.append("Factor de escala: ").append(densidadLogica).append("x");
// 5. Mostramos el resultado en el TextView
        tvInfo.setText(mensaje.toString());
    }
}