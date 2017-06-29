@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo curso...</h1>
		<p class="lead">Insira toda a informação sobre o curso.</p>
		<hr>
		<form action="{{ route('curso.store')}}" method="POST">
			<div class="form-group">
				<label for="nome" class="control-label">Nome:</label>
				<input type="text" id="nome" name="nome" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="tipodecurso" class="control-label">Tipo de Curso:</label>
				<input type="text" id="tipodecurso" name="tipodecurso" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="responsavel" class="control-label">Respons�vel:</label>
				<input type="text" id="responsavel" name="responsavel" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="descricao" class="control-label">Descri��o:</label>
				<input type="text" id="descricao" name="descricao" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="email" class="control-label">Email:</label>
				<input type="email" id="email" name="email" class="form-control" required>
			</div>



			<div class="form-group">
				<label for="telefone" class="control-label">ECTS:</label>
				<input type="number" id="ects" name="ects" class="form-control" required>
			</div>


			<input type="submit" value="Inserir novo curso" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
