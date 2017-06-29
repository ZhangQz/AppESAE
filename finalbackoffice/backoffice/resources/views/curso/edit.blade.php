@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Editar cliente "{{ $curso->id }}"</h1>
		<p class="lead">Edite a informação pretendida e carregue no botão guardar.</p>
		<hr>
		<form action="{{ route('curso.update', $curso->id)}}" method="POST">
			<input type="hidden" name="_method" value="PUT">


			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" value="{{ $curso->id }}" readonly>
			</div>

			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" value="{{ $curso->nome }}" required>
			</div>

			<div class="form-group">
				<label for="tipodecurso" class="control-label">Tipo de Curso:</label>
				<input type="text" id="tipodecurso" name="tipodecurso" class="form-control" value="{{ $curso->tipodecurso }}" required>
			</div>

			<div class="form-group">
				<label for="responsavel" class="control-label">Respons�vel:</label>
				<input type="text" id="responsavel" name="responsavel" class="form-control" value="{{ $curso->responsavel }}" required>
			</div>

			<div class="form-group">
				<label for="descricao" class="control-label">Descrição:</label>
				<input type="text" id="descricao" name="descricao" class="form-control" value="{{ $curso->descricao }}" required>
			</div>

			<div class="form-group">
				<label for="email" class="control-label">Email:</label>
				<input type="email" id="email" name="email" class="form-control" value="{{ $curso->email }}" required>
			</div>

			<div class="form-group">
				<label for="telefone" class="control-label">ECTS:</label>
				<input type="number" id="ects" name="ects" class="form-control" value="{{ $curso->ects }}" required>
			</div>


			<input type="submit" value="Guardar" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
