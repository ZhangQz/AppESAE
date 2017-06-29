@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar uma nova disciplina...</h1>
		<p class="lead">Insira toda a informação sobre o disciplina.</p>
		<hr>
		<form action="{{ route('disciplina.store')}}" method="POST">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" readonly>
			</div>

			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" required>
			</div>

			<input type="submit" value="Inserir novo disciplina" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
