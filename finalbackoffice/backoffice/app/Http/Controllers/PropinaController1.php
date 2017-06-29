<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\Redirect;
use App\Curso;
use App\Utilizador;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;
use App\Propina;

class PropinaController1 extends Controller
{
	public function index() {
		$propinas = Propina::all();
		if (is_null($propinas))
			return redirect()->route("index")->withErrors('Erro ao carregar propinas. Por favor, tente mais tarde.');
			else
				return view("propina.index", compact("propinas"));

	}//


	public function create() {
		return view("propina.create");
	}

	public function store(Request $dados) {
		$propina = Propina::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($propina))
			return redirect()->route('propina.index')->withErrors('Erro ao criar propina. Por favor, tente novamente.');
			else
				return redirect()->route('propina.index')->with('Propina inserida com sucesso!');
	}

	public function show($id) {
		$propina = Propina::findOrFail($id); //retorna o veículo a mostrar
		$propina->curso = Curso::find($propina->curso);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($propina))
			return redirect()->route('propina.index')->withErrors('Erro ao carregar Propinas. Por favor, tente novamente.');
			else
				return view('propina.item', compact('propina'));
	}

	public function edit($id) {
		$propina = Propina::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($propina)) {
			return redirect()->route('propina.index')->withErrors('Erro ao carregar propina. Por favor, tente novamente.');
		}
		else
		{


			return view('propina.edit', compact('propina'));
		}
	}

	public function update(Request $dados, $id) {
		$propina = Propina::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($propina)) {
			return redirect()->route('propina.index')->withErrors('Erro ao carregar propina. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_propina = $dados->all();
			$propina->fill($dados_propina)->save(); //atualiza os dados na BD

			return redirect()->route('propina.index')->with('flash_message', 'Propina atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$propina = Propina::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($propina)) {
			return redirect()->route('propina.index')->withErrors('Erro ao carregar Propina. Por favor, tente novamente.');
		}
		else
		{
			$propina->delete(); //apaga os dados da BD

			return redirect()->route('propina.index')->with('flash_message', 'Propina apagada com sucesso!');
		}
	}
}
