<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\Redirect;
use App\Curso1;
use App\Utilizador1;
use App\Disciplina1;
use App\Documento1;
use App\Evento1;
use App\User1;
use App\Propina1;

class DocumentoController1 extends Controller
{
	public function index() {
		$documentos = Documento1::all();
		if (is_null($documentos))
			return redirect()->route("index")->withErrors('Erro ao carregar documentos. Por favor, tente mais tarde.');
			else
				return view("documento.index", compact("documentos"));

	}//


	public function create() {
		return view("documento.create");
	}

	public function store(Request $dados) {
		$documento = Documento1::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($documento))
			return redirect()->route('documento.index')->withErrors('Erro ao criar documento. Por favor, tente novamente.');
			else
				return redirect()->route('documento.index')->with('Documento inserida com sucesso!');
	}

	public function show($id) {
		$documento = Documento1::findOrFail($id); //retorna o veículo a mostrar
		$documento->curso = Documento::find($documento-curso);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($documento))
			return redirect()->route('documento.index')->withErrors('Erro ao carregar Documento. Por favor, tente novamente.');
			else
				return view('documento.item', compact('documento'));
	}

	public function edit($id) {
		$documento = Documento1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($documento)) {
			return redirect()->route('documento.index')->withErrors('Erro ao carregar documento. Por favor, tente novamente.');
		}
		else
		{


			return view('documento.edit', compact('documento'));
		}
	}

	public function update(Request $dados, $id) {
		$documento = Documento1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($documento)) {
			return redirect()->route('documento.index')->withErrors('Erro ao carregar documento. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_documento = $dados->all();
			$documento->fill($dados_documento)->save(); //atualiza os dados na BD

			return redirect()->route('documento.index')->with('flash_message', 'Documento atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$documento = Documento1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($documento)) {
			return redirect()->route('documento.index')->withErrors('Erro ao carregar documento. Por favor, tente novamente.');
		}
		else
		{
			$documento->delete(); //apaga os dados da BD

			return redirect()->route('documento.index')->with('flash_message', 'Documento apagado com sucesso!');
		}
	}
}
