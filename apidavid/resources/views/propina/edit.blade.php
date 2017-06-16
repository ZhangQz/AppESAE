@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Editar Propina "{{ $propina->id }}"</h1>
		<p class="lead">Edite a informação pretendida e carregue no botÃ£o guardar.</p>
		<hr>
		<form action="{{ route('propina.update', $propina->id)}}" method="POST">
			<input type="hidden" name="_method" value="PUT">
			
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" value="{{ $propina->id }}" readonly>
			</div>
			
			<div class="form-group">
				<label for="id" class="control-label">Ano:</label>
				<input type="number" id="ano" name="ano" class="form-control" value="{{ $propina->ano }}" required>
			</div>
			
			<div class="form-group">
				<label for="mes" class="control-label">Mês:</label>
				<input type="text" id="mes" name="mes" class="form-control" value="{{ $propina->mes }}" required>
			</div>
			
			<div class="form-group">
				<label for="valor" class="control-label">Valor:</label>
				<input type="number" id="valor" name="valor" class="form-control" value="{{ $propina->valor }}" required>
			</div>
			
			<div class="form-group">
				<label for="pago" class="control-label">Pago:</label>
				<select name="pago">
				
				<option value=0>0</option>
				<option value=1>1</option>
				</select>
			</div>
			
			
			
		</div>
			
			
			
			

		
			<input type="submit" value="Guardar" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection