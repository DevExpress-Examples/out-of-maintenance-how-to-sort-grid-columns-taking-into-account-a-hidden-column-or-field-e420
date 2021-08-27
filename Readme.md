<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631985/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E420)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication9/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication9/Form1.vb))
* [Program.cs](./CS/WindowsApplication9/Program.cs) (VB: [Program.vb](./VB/WindowsApplication9/Program.vb))
<!-- default file list end -->
# How to sort grid columns taking into account a hidden column or field


<p>Sometimes you need to keep an internal grouping when a user sorts against grid columns. Assume that you have a list of products. Every product belongs to a particular category.  A user is able to sort it against the product name and product ID. However, it's necessary to keep an internal sort order against categories. <br />
It can be easily implemented using the GridView.CustomColumnSort event.</p>

<br/>


