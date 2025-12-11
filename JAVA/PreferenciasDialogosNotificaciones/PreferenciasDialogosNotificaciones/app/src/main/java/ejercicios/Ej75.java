package ejercicios;

import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Intent;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.NotificationCompat;

import com.example.preferenciasdialogosnotificaciones.R;

public class Ej75 extends AppCompatActivity implements View.OnClickListener {

    NotificationManager notifier;
    Button btn;
    private static final String CHANNEL_ID = "canal_ID";

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_actividad5);

        btn = findViewById(R.id.botonNotificar);

        btn.setOnClickListener(this);

        notifier = (NotificationManager) getSystemService(NOTIFICATION_SERVICE);

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            NotificationChannel channel = new NotificationChannel(
                    CHANNEL_ID,
                    "Canal Notificaciones",
                    NotificationManager.IMPORTANCE_HIGH
            );
            channel.setDescription("Canal para notificación de Ej75");
            notifier.createNotificationChannel(channel);
        }
    }

    @Override
    public void onClick(View v) {
        lanzarNotificacion();
    }

    private void lanzarNotificacion() {

        Intent intent = new Intent(Intent.ACTION_VIEW, Uri.parse("https://dribbble.com/"));

        PendingIntent pIntent = PendingIntent.getActivity(this,0,intent
                ,PendingIntent.FLAG_UPDATE_CURRENT|PendingIntent.FLAG_IMMUTABLE);

        NotificationCompat.Builder builder = new NotificationCompat.Builder(this, "canal_ID")
                .setSmallIcon(R.drawable.outline_currency_rupee_24)
                .setContentTitle("GOOGLE ANGEL")
                .setContentText("si haces click aquí te vas a una página de google")
                .setTicker("EXPANDE ESTA NOTIFICACION YA!")
                .setAutoCancel(true)
                .setContentIntent(pIntent);

        notifier.notify(1,builder.build());
    }
}
