@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo documento...</h1>
		<p class="lead">Insira toda a informação sobre o documento.</p>
		<hr>
		<form action="{{ route('documento.store')}}" method="POST">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="nome" name="nome" class="form-control" readonly>
			</div>
			
			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" required>
			</div>
			
			<div class="form-group">
				<label for="categoria" class="control-label">Categoria:</label>
				<select name="categoria">
				
				<option value=Boletim>Boletim</option>
				<option value=Criterios>Criterios</option>
				<option value=Capas>Capas</option>
				<option value=Entregas>Entregas</option>
				</select>
			</div>
			

			
			

			<input type="submit" value="Inserir novo documento" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection