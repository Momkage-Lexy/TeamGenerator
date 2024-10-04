// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addNameField() {
    // Create element
    const div = document.createElement('div');

    div.className = 'nameField';
    // Define element
    div.innerHTML = `
      <input type="text" name="name" value="" />
    `;
    
    // Add to div 'newField' on form
    document.getElementById('newField').appendChild(div);
}