@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Editar evento "{{ $evento->id }}"</h1>
		<p class="lead">Edite a informação pretendida e carregue no botÃ£o guardar.</p>
		<hr>
		<form action="{{ route('evento.update', $evento->id)}}" method="POST">
			<input type="hidden" name="_method" value="PUT">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" value="{{ $evento->id }}" readonly>
			</div>
			
			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" value="{{ $evento->nome }}" required>
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
				<input type="text" id="tipo" name="local" class="form-control" value="{{ $evento->local}}" required>
			</div>
			
		</div>
			
			
			
			

		
			<input type="submit" value="Guardar" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection