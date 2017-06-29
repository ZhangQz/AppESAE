@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Editar User "{{ $user->id }}"</h1>
		<p class="lead">Edite a informação pretendida e carregue no botão guardar.</p>
		<hr>
		<form action="{{ route('user.update', $user->id)}}" method="POST">
			<input type="hidden" name="_method" value="PUT">

			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" value="{{ $user->id }}" readonly>
			</div>

			<div class="form-group">
				<label for="id" class="control-label">Numero:</label>
				<input type="number" id="numero" name="numero" class="form-control" value="{{ $user->numero }}" required>
			</div>

			<div class="form-group">
				<label for="password" class="control-label">Password:</label>
				<input type="password" id="password" name="password" class="form-control" value="{{ $user->password }}" required>
			</div>

		</div>


			<input type="submit" value="Guardar" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
</form>
