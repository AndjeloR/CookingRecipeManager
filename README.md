# Cooking Recipe Manager

A simple Windows Forms desktop application for managing cooking recipes with image support and alphabetical sorting capabilities.

## Features

- Add Recipes: Create new recipes with name, ingredients, and instructions
- Upload Images: Attach recipe images (JPG, JPEG, PNG formats)
- View Recipes: Browse all saved recipes in a list view
- Delete Recipes: Remove recipes from your collection
- Sort Recipes: Sort recipes alphabetically (A-Z or Z-A)
- Edit Recipes: Select and modify existing recipes
- Clear Form: Quickly reset input fields

## Project Structure

The project is organized with a main form (Form1.cs) that handles the user interface, a Recipe class that serves as the data model, and an auto-generated designer file for the UI layout.

## How to Use

### Adding a Recipe

Start by entering the recipe title in the "Recipe Title" field. Then add your ingredients in the ingredients text area and cooking instructions in the instructions text area. If you want to include a photo, click the Upload button to select a recipe image from your computer (JPG, JPEG, or PNG formats are supported). Once everything is filled in, click Save to add the recipe to your collection.

### Managing Recipes

To view a recipe, simply click on it in the list and its details will appear in the form fields. You can edit any recipe by selecting it, modifying the fields as needed, and clicking Save again. To remove a recipe, select it from the list and click Delete. If you want to reset all the input fields without saving, click Clear.

### Sorting

Use the sort dropdown menu to organize your recipes. You can sort alphabetically from A to Z or in reverse from Z to A. The list will automatically update based on your sorting preference.

## Technical Details

### Recipe Class

The Recipe class is a simple data model that stores recipe information. It contains four properties: the Name property stores the recipe title, the Ingredients property holds the ingredient list, the Instructions property contains the cooking directions, and the ImagePath property stores the file path to the recipe image. The class includes a ToString() override that returns the recipe name for display in the list.

### Key Methods

The btnSave_Click() method validates the recipe name and adds new recipes to the collection, then applies sorting and clears the form. The btnUpload_Click() method opens a file dialog allowing users to select recipe images from their computer. The ApplySorting() method handles sorting the recipe list based on the dropdown selection. The RefreshList() method updates the display with the current recipe list by rebinding the data source. The ClearInput() method resets all form fields and clears the selected image. The btnDelete_Click() method removes the selected recipe from the collection.

## Requirements

You will need the .NET Framework version 4.7.2 or higher to run this application. Windows Forms library support is required, and Visual Studio 2019 or later is recommended for development and building the project.
