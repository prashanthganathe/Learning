<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="HTMLPDF.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<style>
table {
    width:100%;
}
table, th, td {
    border: 1px solid black;
    border-collapse: collapse;
}
th, td {
    padding: 5px;
    text-align: left;
}
table#t01 tr:nth-child(even) {
    background-color: #eee;
}
table#t01 tr:nth-child(odd) {
   background-color:#fff;
}
table#t01 th	{
    background-color: black;
    color: white;
}

body
{
    
}
</style>

    <h3 >Your contact page.</h3>
    <address style="background-color:green;">
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <div  style='margin: 5px;
    padding: 5px;
    border: 1px solid #0000ff;
    height: auto;
    width: auto;
    float: left;
    text-align: center;'>
  <a target='_blank' href='klematis_big.htm'>
   
  </a>
  <div style='text-align: center;
    font-weight: normal;
    width: 120px;
    margin: 5px;'>Add a description of the image here</div>
</div>
<div style='margin: 5px;
    padding: 5px;
    border: 1px solid #0000ff;
    height: auto;
    width: auto;
    float: left;
    text-align: center;'>
  <a target='_blank' href='klematis2_big.htm'>
    <img src="http://localhost:1860/images/dsc_0111.jpg"  height="200" width="200"></img>
  </a>
  <div style='text-align: center;
    font-weight: normal;
    width: 120px;
    margin: 5px;'>Add a description of the image here</div>
</div>
    


<table id="t01" style="background-color:#b6ff00;">
  <tr>
    <th>First Name</th>
    <th>Last Name</th>		
    <th>Points</th>
  </tr>
  <tr>
    <td>Jill</td>
    <td>Smith</td>		
    <td>50</td>
  </tr>
  <tr>
    <td>Eve</td>
    <td>Jackson</td>		
    <td>94</td>
  </tr>
  <tr>
    <td>John</td>
    <td>Doe</td>		
    <td>80</td>
  </tr>
</table>


</asp:Content>
