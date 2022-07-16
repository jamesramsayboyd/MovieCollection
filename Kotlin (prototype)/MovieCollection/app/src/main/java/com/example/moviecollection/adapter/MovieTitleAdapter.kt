package com.example.moviecollection.adapter

import android.content.Context
import android.content.Intent
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.RecyclerView
import com.example.moviecollection.DetailedInfoActivity
import com.example.moviecollection.MainActivity
import com.example.moviecollection.R
import com.example.moviecollection.model.Movie

/**
 * Adapter for the [RecyclerView] in [MainActivity]. Displays [Movie] data object.
 */
class MovieTitleAdapter(
    private val context: Context,
    private val dataset: MutableList<Movie?>
) : RecyclerView.Adapter<MovieTitleAdapter.ItemViewHolder>() {

    /**
     * Provide a reference to the views for each data item
     * Complex data items may need more than one view per item, and
     * you provide access to all the views for a data item in a view holder.
     * Each data item is just an Movie object.
     */
    class ItemViewHolder(val view: View) : RecyclerView.ViewHolder(view) {
        val button: Button = view.findViewById(R.id.button_item)
    }

    /**
     * Create new views (invoked by the layout manager
     */
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ItemViewHolder {
        // create a new view
        val adapterLayout = LayoutInflater
            .from(parent.context)
            .inflate(R.layout.list_item, parent, false)

        return ItemViewHolder(adapterLayout)
    }

    /**
     * Replace the contents of a view (invoked by the layout manager)
     */
    override fun onBindViewHolder(holder: ItemViewHolder, position: Int) {
        val item: Movie? = dataset[position]
        holder.button.text = item?.title
        holder.button.setOnClickListener {
            val context = holder.view.context
            val intent = Intent(context, DetailedInfoActivity::class.java)
            intent.putExtra("movie", item)
            intent.putExtra("index", position)
            context.startActivity(intent)
        }
    }

    /**
     * Return the size of your dataset (invoked by the layout manager)
     */
    override fun getItemCount() = dataset.size
}