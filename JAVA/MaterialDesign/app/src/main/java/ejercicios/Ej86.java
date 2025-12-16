package ejercicios;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;
import androidx.activity.OnBackPressedCallback;
import androidx.annotation.NonNull;
import androidx.appcompat.app.ActionBarDrawerToggle;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;

import com.example.materialdesign.R;
import com.google.android.material.appbar.MaterialToolbar;
import com.google.android.material.navigation.NavigationView;

public class Ej86 extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {

    private DrawerLayout drawerLayout;
    private NavigationView navigationView;
    private MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_activity6);

        drawerLayout = findViewById(R.id.drawer_layout);
        navigationView = findViewById(R.id.navigation_view);
        toolbar = findViewById(R.id.toolbar);

        setSupportActionBar(toolbar);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this,
                drawerLayout,
                toolbar,
                R.string.navigation_drawer_open,R.string.navigation_drawer_close);

        drawerLayout.addDrawerListener(toggle);
        toggle.syncState();

        if (navigationView != null) {
            navigationView.setNavigationItemSelectedListener(this);
        }

        OnBackPressedCallback callback = new OnBackPressedCallback(true) {
            @Override
            public void handleOnBackPressed() {

                if (drawerLayout.isDrawerOpen(GravityCompat.START)) {
                    drawerLayout.closeDrawer(GravityCompat.START);
                } else {
                    setEnabled(false);
                    getOnBackPressedDispatcher().onBackPressed();
                    setEnabled(true);
                }
            }
        };
        getOnBackPressedDispatcher().addCallback(this, callback);
    }
    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
        String title = menuItem.getTitle().toString();
        menuItem.setChecked(true);
        Toast.makeText(getApplicationContext(), "Cargando género: " + title, Toast.LENGTH_SHORT).show();

        int id = menuItem.getItemId();
        if (id == R.id.nav_salida) {
            Toast.makeText(getApplicationContext(), "¡Hasta la próxima partida!", Toast.LENGTH_LONG).show();
            finishAffinity();
        } else if (id == R.id.nav_tutorial) {
            Toast.makeText(getApplicationContext(), "Consultando manual...", Toast.LENGTH_SHORT).show();
        }
        drawerLayout.closeDrawers();
        return true;
    }
}
