package com.example.moviecollection

import android.content.Intent
import android.os.Bundle
import android.widget.*
import androidx.appcompat.app.ActionBar
import androidx.appcompat.app.AppCompatActivity
import com.example.moviecollection.model.Movie

class EditMovieActivity : AppCompatActivity() {

    companion object {
        var MOVIE = Movie("title", 0, "director", "format", false)
    }
    var INDEX: Int = 0

    private lateinit var editTextTitle: EditText
    private lateinit var editTextYear: EditText
    private lateinit var editTextDirector: EditText
    private lateinit var radioButtonDVD: RadioButton
    private lateinit var radioButtonBlu: RadioButton
    private lateinit var radioButton4K: RadioButton
    private lateinit var switchFavourite: Switch
    private lateinit var buttonEdit: Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_edit_movie)
        this.title = "Edit movie"

        MOVIE = intent?.extras?.getSerializable("movie") as Movie
        INDEX = intent?.extras?.getInt("index") as Int

        // setting app toolbar
        setSupportActionBar(findViewById(R.id.edit_toolbar))
        val actionBar: ActionBar = getSupportActionBar() as ActionBar
        actionBar.setDisplayHomeAsUpEnabled(true)

        editTextTitle = findViewById(R.id.edit_title_edit)
        editTextYear = findViewById(R.id.edit_year_edit)
        editTextDirector = findViewById(R.id.edit_director_edit)
//        val radioGroupFormat: RadioGroup = findViewById(R.id.radio_group_edit)
        radioButtonDVD = findViewById(R.id.radio_button_DVD_edit)
        radioButtonBlu = findViewById(R.id.radio_button_blu_edit)
        radioButton4K = findViewById(R.id.radio_button_4K_edit)
        switchFavourite = findViewById(R.id.switch_favourite_edit)
        buttonEdit = findViewById(R.id.button_edit_movie)

        displayMovie(MOVIE)

        buttonEdit.setOnClickListener {
            editMovie(INDEX)
            val intent = Intent(this, MainActivity::class.java)
            startActivity(intent)
        }
    }

    private fun radioGroupString(): String {
        return if (radioButtonDVD.isChecked) {
            "DVD"
        } else if (radioButtonBlu.isChecked) {
            "Blu Ray"
        } else
            "4K UHD"
    }

    private fun displayMovie(a: Movie) {
        editTextTitle.setText(a.title)
        editTextYear.setText(a.year.toString())
        editTextDirector.setText(a.director)
        when (a.format) {
            "DVD" -> {
                radioButtonDVD.toggle()
            }
            "Blu Ray" -> {
                radioButtonBlu.toggle()
            }
            else -> {
                radioButton4K.toggle()
            }
        }
        when (a.favourite) {
            true -> {
                switchFavourite.toggle()
            }
            else -> {}
        }
    }

    private fun editMovie(index: Int) {
        val movieToEdit = Movie(
            editTextTitle.text.toString(),
            editTextYear.text.toString().toInt(),
            editTextDirector.text.toString(),
            radioGroupString(),
            switchFavourite.isChecked
        )
        val saveManager = SharedPreferenceManager(this)
        val list = saveManager.loadMovieList()
        list.removeAt(index)
        list.add(movieToEdit)
        saveManager.saveMovieList(list)
    }
}