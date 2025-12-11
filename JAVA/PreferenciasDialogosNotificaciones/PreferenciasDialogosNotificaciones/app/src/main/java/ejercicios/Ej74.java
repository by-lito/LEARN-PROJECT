package ejercicios;

import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.TimePickerDialog;
import android.os.Bundle;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.preferenciasdialogosnotificaciones.R;

import java.util.Calendar;

public class Ej74 extends AppCompatActivity implements View.OnClickListener {

    Button btnFecha, btnHora;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_actividad4);

        btnFecha = findViewById(R.id.btnMostrarFecha);
        btnHora = findViewById(R.id.btnMostrarHora);

        btnHora.setOnClickListener(this);
        btnFecha.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

        if (v.getId() == R.id.btnMostrarHora) {
            mostrarDialogoHora();
        } else if (v.getId() == R.id.btnMostrarFecha) {
            mostrarDialogoFecha();
        }
    }

    private void mostrarToastPersonalizado(String message){

        LayoutInflater inflater = getLayoutInflater();
        View layout = inflater.inflate(
                R.layout.toast_personalizado_layout,
                (ViewGroup) findViewById(R.id.custom_toast_container)
        );

        TextView txt = layout.findViewById(R.id.textViewToast);
        txt.setText(message);

        Toast toast = new Toast(getApplicationContext());
        toast.setDuration(Toast.LENGTH_LONG);
        toast.setGravity(Gravity.BOTTOM,0,400);
        toast.setView(layout);
        toast.show();
    }

    private void mostrarDialogoFecha() {

        Calendar c = Calendar.getInstance();
        int annio = c.get(Calendar.YEAR);
        int mes = c.get(Calendar.MONTH);
        int dia = c.get(Calendar.DAY_OF_MONTH);

        DatePickerDialog dpd = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker view, int year, int month, int dayOfMonth) {
                mostrarToastPersonalizado(dayOfMonth + "|" + (month + 1) + "|" + year);
            }
        },annio,mes,dia);

        dpd.show();

    }

    private void mostrarDialogoHora() {

        Calendar c = Calendar.getInstance();
        int hora = c.get(Calendar.HOUR);
        int min = c.get(Calendar.MINUTE);

        TimePickerDialog tpd = new TimePickerDialog(this, new TimePickerDialog.OnTimeSetListener() {
            @Override
            public void onTimeSet(TimePicker view, int hourOfDay, int minute) {
                mostrarToastPersonalizado(String.format("%02d:%02d", hourOfDay, minute));
            }
        },hora, min, true);
        tpd.show();
    }
}
