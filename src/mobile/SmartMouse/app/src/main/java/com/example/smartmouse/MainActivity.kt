package com.example.smartmouse

import android.os.Bundle
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.smartmouse.databinding.ActivityMainBinding
import com.example.smartmouse.SensorInterface

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)

        val sensor = SensorInterface().testFun()

        binding.valueX.text = sensor.x.toString()
        binding.valueY.text = sensor.y.toString()
        binding.valueZ.text = sensor.z.toString()
    }
}