//using System.Dynamic;

dynamic d = 87;
d = "Does this compile? Yes!";
d.ThrowsRuntimeError();


//dynamic contact = new ExpandoObject();
//contact.FirstName = "Jesper";
//contact.LastName = "Gulmann Henriksen";

//Console.WriteLine(contact.FirstName + " " + contact.LastName);

//contact.BusinessAddress = new ExpandoObject();
//contact.BusinessAddress.Street = "Aastvej 1";
//contact.BusinessAddress.ZipCode = "7190";
//contact.Address.City = "Billund";

//Console.WriteLine(
//    contact.BusinessAddress.Street + ", " +
//    contact.BusinessAddress.ZipCode + " " +
//    contact.BusinessAddress.City
//);
