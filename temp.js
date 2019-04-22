console.log(body.parentNode);
console.log(body.children);
console.log(document.getElementById('body'));
console.log(document.querySelector('body'))
console.log(document.querySelector('body .container'))
body.children[1].style.backgroundColor = 'yellow';

console.log(body.firstElementChild);

document.getElementsByClassName

var button = document.getElementById('button').addEventListener('click', buttonClick);

function buttonClick(e){
    console.log(e.target);
    var output = document.getElementById('output');
    output.innerHTML = '<h3>Test input</h3>';
}


var form = document.querySelector('form');
form.addEventListener('submit', runEvent);

var itemLis = document.getElementById('items');

var filter = document.getElementById('filter');

function runEvent(e){
    console.log('EVENT TYPE:' +e.type);
}

//form submit add item
form.addEventListener('submit', addItem);

//delete from list on btn click
itemLis.addEventListener('click', removeItem);

filter.addEventListener('keyup', filterItems);

function filterItems(e){
    // get text from text box
    var text = e.target.value.toLowerCase();

    //get list
    var items = itemLis.getElementsByTagName('li');

    Array.from(items).forEach(function(item){
        var itemName = item.firstChild.textContent;
        if(item.toLowerCase().indexOf(text) != -1){
            item.style.display = 'block';
        }else{
            item.style.display = 'none';
        }
    });

}

function removeItem(e){
    if(e.target.classList.contains('delete')){
        if(confirm('Are you asure?')){
            var li = e.target.parentElement;
            itemLis.removeChild(li);
        }
    }
}

function addItem(e){
    e.preventDefault();

    //Get input value
    var newItem = document.getElementById('item').value;

    //Create new li element
    var li = document.createElement('li');
    // add class
    li.className = 'list-group-item';
    //add text with input node
    li.appendChild(document.createTextNode(newItem));

    //create del button
    var deleteBtn = document.createElement('button');
    //add classes to deleteBtn
    deleteBtn.className = 'btn btn-danger btn=sm';
    //give delete button x
    deleteBtn.appendChild(document.createTextNode('x'));
    //append Button to li
    li.appendChild(deleteBtn);
    //append li to list
    itemLis.appendChild(li);


}