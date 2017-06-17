@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Editar Utilizador "{{ $utilizador->id }}"</h1>
		<p class="lead">Edite a informação pretendida e carregue no botÃ£o guardar.</p>
		<hr>
		<form action="{{ route('utilizador.update', $utilizador->id)}}" method="POST">
			<input type="hidden" name="_method" value="PUT">
			
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" value="{{ $utilizador->id }}" readonly>
			</div>
			
			<div class="form-group">
				<label for="id" class="control-label">Numero:</label>
				<input type="text" id="numero" name="numero" class="form-control" value="{{ $utilizador->numero }}" required>
			</div>
			
			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" value="{{ $utilizador->nome }}" required>
			</div>
			
			
			
			
			
		</div>
			
			
			
			

		
			<input type="submit" value="Guardar" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
</form>