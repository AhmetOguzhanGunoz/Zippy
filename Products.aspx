<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link rel="stylesheet" type="text/css" href="Style.css"/>
		
	<title>
		Welcome ZippyDress Website
	</title>

</head>
<body>
    <form id="form1" runat="server">

	<div id="banner">
		
		<div id="head">

			<img src="logo.png"/>
			<h2>Welcome ZippyDress</h2>

		</div>

		<div id="area">
		
			<div id="commonBar">

						<ul>
						<li> <a href="http://www.google.com.tr">Google</a> </li>
						<li> <a href="http://www.youtube.com">Youtube</a> </li>
						<li> <a href="http://www.facebook.com">Facebook</a> </li>
						<li> <a href="http://www.twitter.com">TwItter</a> </li>
						<li> <a href="http://www.iku.edu.tr">Iku</a> </li>
						</ul>

			</div>

			<div id="searchBar">

				<input type="text" placeholder="  Search in the Website..."/>
				<input type="submit" value="   "/> 

			</div>
		
		</div>

	</div>

	<div id="content">

		<div class="sideBar">

			<ul>
			<li><a href="Home.aspx ">Home</a></li>
			<li><a href="AboutUs.aspx">About Us</a></li>
			<li><a href="Products.aspx ">Products</a></li>
			<li><a href="Contacts.aspx ">Contacts</a></li>
			</ul>
	
		</div>

		<div id="mainContent">


		<ul>
		<li>Shirts<img src="Shirt-men.jpg"/><img src="Shirt-women.jpg"/></li>
		<li>Jeans<img src="jean-man.jpg"/><img src="jean-women.jpg"/></li>
		<li>Waistcoats<img src="yelek-bay.jpg"/><img src="yelek-bayan.jpg"/></li>
		<li>Trainers<img src="spor-erkek.jpg"/><img src="spor-bayan.jpg"/></li>
		</ul>

		</div>

		<div class="sideBar">

			<h4>Only For This Week</h4>
			<h1>%50 Promotion</h1>
	
		</div>

	</div>

	<div id="footer">

		<p>IKU Web Programming - Ahmet Oğuzhan Günöz - Copyright © 2016 - All Rights Reserved</p>

	</div>

    </form>
</body>
</html>
