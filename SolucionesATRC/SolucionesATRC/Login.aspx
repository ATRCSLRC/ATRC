<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SolucionesATRC.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>Login V18</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
    <link rel="stylesheet" type="text/css" href="Content/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Content/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Content/css/util.css">
	<link rel="stylesheet" type="text/css" href="Content/css/main.css">
<!--===============================================================================================-->
</head>
<body style="background-color: #666666;">
	<div class="limiter" >
		<div class="container-login100">
			<div class="wrap-login100">
				<form class="login100-form validate-form" runat="server">
					<span class="login100-form-title" style="background-image: url('Content/Login/img/logo.png');"> 
                       
					</span>
					
					
					<div class="wrap-input100 validate-input"  data-validate = "Correo requerido">
						<input class="input100" type="text" name="email" id="email" runat="server">
						<span class="focus-input100"></span>
						<span class="label-input100">Correo</span>
					</div>
					
					<div class="wrap-input100 validate-input" data-validate="Contraseña requerida">
						<input class="input100" type="password" name="pass" id="pass" runat="server">
						<span class="focus-input100"></span>
						<span class="label-input100">Contrase&ntilde;a</span>
					</div>

					<!--<div class="flex-sb-m w-full p-t-3 p-b-32">
						<div class="contact100-form-checkbox">
							<input class="input-checkbox100" id="ckb1" type="checkbox" name="remember-me">
							<label class="label-checkbox100" for="ckb1">
								Remember me
							</label>
						</div>

						<div>
							<a href="#" class="txt1">
								Forgot Password?
							</a>
						</div>
					</div>-->
			

					<div class="container-login100-form-btn">
                        <dx:BootstrapButton ID="BootstrapButton1" runat="server" AutoPostBack="false" Text="Login" CssClasses-Control="login100-form-btn" >
                            <ClientSideEvents Click="function(s,e){ $('.validate-form').submit();}" />
                        </dx:BootstrapButton>
						<%--<button class="login100-form-btn">
							Login
						</button>--%>
					</div>
					
					<!--<div class="text-center p-t-46 p-b-20">
						<span class="txt2">
							or sign up using
						</span>
					</div>

					<div class="login100-form-social flex-c-m">
						<a href="#" class="login100-form-social-item flex-c-m bg1 m-r-5">
							<i class="fa fa-facebook-f" aria-hidden="true"></i>
						</a>

						<a href="#" class="login100-form-social-item flex-c-m bg2 m-r-5">
							<i class="fa fa-twitter" aria-hidden="true"></i>
						</a>
					</div>-->
                    <dx:ASPxCallback ID="CallbackLogin" ClientInstanceName="CallbackLogin" OnCallback="CallbackLogin_Callback" runat="server">
                        <ClientSideEvents BeginCallback="function(s,e){ alert('inicio');}" CallbackComplete="function(s,e){ alert(e.result);}" CallbackError="function(s,e){ alert('error');}" EndCallback="function(s,e){ alert('end');}" />
                    </dx:ASPxCallback>
				</form>

				<div class="login100-more" style="background-image: url('Content/Login/img/bg-01.jpg');">
				</div>
			</div>
		</div>
	</div>
<!--===============================================================================================-->
    <script src="Content/js/jquery-3.2.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/gasparesganga-jquery-loading-overlay@2.1.7/dist/loadingoverlay.min.js" defer></script>
    <script src="Content/js/popper.js"></script>
	<script src="Content/js/bootstrap.min.js"></script>
	<script src="Content/js/main.js"></script>

</body>
</html>