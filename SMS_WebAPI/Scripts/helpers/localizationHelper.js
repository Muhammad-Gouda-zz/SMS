//to localize html attributes like value, placeholder, etc
//by Muhammad Gouda 20/12/2014
var localize = function (culture,//ar-EG for arabic, en-US or default for English, etc
    key, //the key is gotten from Globalize.cultures[culture].messages inside ../globalize/globalize.js 
        //based on the passed culture the value is obtained from the rigth file 
        //for example if culture="ar-EG", the value is obtained from ../globalize/globalize.cutlure.ar-EG.js
        //So, these globalize.cutlure files act as resources
    controlId, //the id of the control to which you want to localize an attribute 
    attribute //the target attribute (e.g. input.value, input.placeholder, input.text, etc)
    )
{
    var localizedText = Globalize.cultures[culture].messages[key];//get the localized value from the suitable js resource file 
    $("#" + controlId).attr(attribute, localizedText);//set the value to the target attribute
}

//belo sample sets the "placeholder" attribute for the input element of id "studentNameSearch"
//to the value of Globalize.cultures["ar-EG"].messages.typeToSearch 
//from the js resource file ../globalize/globalize.cutlure.ar-EG.js
localize("ar-EG", "typeToSearch", "studentNameSearch", "placeholder");