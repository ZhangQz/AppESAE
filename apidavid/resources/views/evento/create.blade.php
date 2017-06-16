@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo evento...</h1>
		<p class="lead">Insira toda a informação sobre o evento.</p>
		<hr>
		<form action="{{ route('evento.store')}}" method="POST">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" readonly>
			</div>
			
			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" required>
			</div>
			
			<div class="form-group">
				<label for="tipo" class="control-label">Tipo:</label>
				<select name="tipo">
				
				<option value=Workshop>Workshop</option>
				<option value=Defesas>Defesas</option>
				<option value=Gerais>Gerais</option>
				<option value=Palestras>Palestras</option>
				</select>
			</div>
			
			<div class="form-group">
				<label for="local" class="control-label">Local:</label>
				<input type="text" id="local" name="local" class="form-control" required>
			</div>
			

			
			

			<input type="submit" value="Inserir novo evento" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection