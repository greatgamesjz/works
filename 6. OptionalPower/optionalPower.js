//createForm(); //uncomment to automatically create form
//addListeners(); //uncomment to automatically add listeners
function createForm()
{
	var input1 = document.createElement("input");
	input1.classList.add("a");
	var input2 = document.createElement("input");
	input2.classList.add("b");
	var button1 = document.createElement("button");
	button1.classList.add("ok-button");
	var button2 = document.createElement("button");
	button2.classList.add("cancel-button");
	var node1 = document.createTextNode("OK");
	var node2 = document.createTextNode("Cancel");
	button1.appendChild(node1);
	button2.appendChild(node2);
	document.querySelector("body").appendChild(input1);
	document.querySelector("body").appendChild(input2);
	document.querySelector("body").appendChild(button1);
	document.querySelector("body").appendChild(button2);
}
function addListeners()
{
	var a;
	var b;
	var okButton = document.querySelector(".ok-button");
	var cancelButton = document.querySelector(".cancel-button");
	okButton.addEventListener("click", function(){
		a=document.querySelector(".a").value;
		b=document.querySelector(".b").value;
		okButton.value="true";
		cancelButton.value="false";
		optionalPow(a, b);})
	cancelButton.addEventListener("click", function(){
		a=document.querySelector(".a").value;
		b=document.querySelector(".b").value;
		okButton.value="false";
		cancelButton.value="true";
		optionalPow(a, b);})
}


//required function
function optionalPow(a, b) {
	var okButton = document.querySelector(".ok-button").value;
	var cancelButton = document.querySelector(".cancel-button").value;
	if(okButton=="true")
		return Math.pow(a,b);
	else if(cancelButton == "true")
		return Math.pow(b,a);
}
