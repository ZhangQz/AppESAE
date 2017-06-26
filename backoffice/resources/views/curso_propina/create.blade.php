@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar um novo curso com propina...</h1>
		<p class="lead">rqr.</p>
		<hr>
		<form action="{{ route('curso_propina.store')}}" method="POST">
			<div class="form-group">
				<label for="curso_id" class="control-label">Id do Curso:</label>
				<select id="curso_id" name="curso_id" class="form-control" required>
					@foreach($cursos as $curso)
						<option value="<?php echo $curso->id; ?>"><?php echo $curso->id; ?></option>
					@endforeach
				</select>
			</div>

			<div class="form-group">
				<label for="propina_id" class="control-label">Id da propina:</label>
				<select id="propina_id" name="propina_id" class="form-control" required>
					@foreach($propinas as $propina)
						<option value="<?php echo $propina->id; ?>"><?php echo $propina->id; ?></option>
					@endforeach
				</select>
			</div>




			<input type="submit" value="Inserir nova propina" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
