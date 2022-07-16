package com.example.moviecollection

import android.content.Intent
import android.os.Bundle
import android.widget.*
import androidx.appcompat.app.ActionBar
import androidx.appcompat.app.AppCompatActivity
import com.example.moviecollection.model.Movie

class AddMovieActivity : AppCompatActivity() {
    private lateinit var editTextTitle: EditText
    private lateinit var editTextYear: EditText
    private lateinit var editTextDirector: EditText
    private lateinit var radioButtonDVD: RadioButton
    private lateinit var radioButtonBlu: RadioButton
    private lateinit var radioButton4K: RadioButton
    private lateinit var switchFavourite: Switch

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_add_movie)

        // setting app toolbar
        setSupportActionBar(findViewById(R.id.add_toolbar))
        val actionBar: ActionBar = getSupportActionBar() as ActionBar
        actionBar.setDisplayHomeAsUpEnabled(true)

        editTextTitle = findViewById(R.id.edit_title)
        editTextYear = findViewById(R.id.edit_year)
        editTextDirector = findViewById(R.id.edit_director)
//        val radioGroupFormat: RadioGroup = findViewById(R.id.radio_group)
        radioButtonDVD = findViewById(R.id.radio_button_DVD)
        radioButtonBlu = findViewById(R.id.radio_button_blu)
        radioButton4K = findViewById(R.id.radio_button_4K)
        switchFavourite = findViewById(R.id.switch_favourite)

        val buttonAddMovie: Button = findViewById(R.id.button_add_movie)
        buttonAddMovie.setOnClickListener {
            addMovie()

            val intent = Intent(this, MainActivity::class.java)
            startActivity(intent)
        }

        this.title = "Add movie"
    }

    private fun radioGroupString(): String {
        return if (radioButtonDVD.isChecked) {
            "DVD"
        } else if (radioButtonBlu.isChecked) {
            "Blu Ray"
        } else if (radioButton4K.isChecked) {
            "4K UHD"
        } else
            ""
    }

    private fun addMovie() {
        val movieToAdd = Movie(
            editTextTitle.text.toString(),
            editTextYear.text.toString().toInt(),
            editTextDirector.text.toString(),
            radioGroupString(),
            switchFavourite.isChecked
        )

        val saveManager = SharedPreferenceManager(this)
        val list: MutableList<Movie?> = saveManager.loadMovieList()
        list.add(movieToAdd)
        saveManager.saveMovieList(list)
    }
}