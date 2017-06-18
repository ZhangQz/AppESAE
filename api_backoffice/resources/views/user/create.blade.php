@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo user...</h1>
		<p class="lead">Insira toda a informação sobre o user.</p>
		<hr>
		<form action="{{ route('user.store')}}" method="POST">

			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" readonly>
			</div>

			<div class="form-group">
				<label for="numero" class="control-label">Numero:</label>
				<input type="number" id="numero" name="numero" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="password" class="control-label">Password:</label>
				<input type="password" id="password" name="password" class="form-control" required>
			</div>

			<input type="submit" value="Inserir novo user" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
