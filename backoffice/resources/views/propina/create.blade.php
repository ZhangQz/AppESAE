@extends('layouts.master')
@section('content')
	<div class="container-fluid">
		<h1>Adicionar uma nova propina...</h1>
		<p class="lead">Insira toda a informa��o sobre a propina.</p>
		<hr>
		<form action="{{ route('propina.store')}}" method="POST">
			<div class="form-group">
				<label for="id" class="control-label">Id:</label>
				<input type="text" id="id" name="id" class="form-control" readonly>
			</div>

			<div class="form-group">
				<label for="ano" class="control-label">Ano:</label>
				<input type="number" id="ano" name="ano" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="mes" class="control-label">Mes:</label>
				<select name="mes">

				<option value=Janeiro>Janeiro</option>
				<option value=Fevereiro>Fevereiro</option>
				<option value=Março>Março</option>
				<option value=Abril>Abril</option>
				<option value=Maio>Maio</option>
				<option value=Junho>Junho</option>
				<option value=Julho>Julho</option>
				<option value=Agosto>Agosto</option>
				<option value=Setembro>Setembro</option>
				<option value=Outubro>Outubro</option>
				<option value=Novembro>Novembro</option>
				<option value=Dezembro>Dezembro</option>
				</select>
			</div>

			<div class="form-group">
				<label for="valor" class="control-label">Valor:</label>
				<input type="number" id="valor" name="valor" class="form-control" required>
			</div>

			<div class="form-group">
				<label for="pago" class="control-label">Pago:</label>
				<select name="pago">

				<option value=0>0</option>
				<option value=1>1</option>
				</select>
			</div>




			<input type="submit" value="Inserir nova propina" class="btn btn-primary">
			<input type="hidden" name="_token" value="{{ csrf_token() }}">
		</form>
	</div>
@endsection
