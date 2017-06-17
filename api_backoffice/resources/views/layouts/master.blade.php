<!DOCTYPE html>
<html lang="pt">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Esae - Página de Administrador</title>
		<link rel="stylesheet" href="{{ asset('css/bootstrap.min.css') }}">
	</head>

	<body>
		<header>
			@include('layouts.includes.menu')
		</header>

		<main>

		<div id="app">
        <nav class="navbar navbar-default navbar-static-top">
            <div class="container">
                <div class="navbar-header">

                    <!-- Collapsed Hamburger -->
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#app-navbar-collapse">
                        <span class="sr-only">Toggle Navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>


                </div>
            </div>
        </nav>


    </div>

			<div class="container-fluid">
				@if($errors->any())
					<div class="alert alert-danger">
						@foreach($errors->all() as $error)
							<p>{{ $error }}</p>
						@endforeach
					</div>
				@endif
			</div>

			<div class="container-fluid">
				@if(session('flash_message'))
			    	<div class="alert alert-success">
			    		{{ session('flash_message') }}
			    	</div>
				@endif
			</div>

			@yield('content')
		</main>

		<footer class="footer navbar-inverse navbar-fixed-bottom">

		</footer>

		<script src="{{ asset('js/jquery-3.1.1.min.js') }}"></script>
		<script src="{{ asset('js/bootstrap.min.js') }}"></script>
	</body>
</html>
