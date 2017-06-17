@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo documento...</h1>
		<p class="lead">Insira toda a informa��o sobre o documento.</p>
		<hr>
		<form action="{{ route('documento.store')}}" method="POST">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" >
			</div>

			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" required>
			</div>
			
			<input type="submit" value="Inserir novo documento" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
