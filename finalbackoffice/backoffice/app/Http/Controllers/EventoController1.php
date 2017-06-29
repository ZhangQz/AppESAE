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

class EventoController1 extends Controller
{
	public function index() {
		$eventos = Evento::all();
		if (is_null($eventos))
			return redirect()->route("index")->withErrors('Erro ao carregar aventos. Por favor, tente mais tarde.');
			else
				return view("evento.index", compact("eventos"));

	}//


	public function create() {
		return view("evento.create");
	}

	public function store(Request $dados) {
		$evento = Evento::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($evento))
			return redirect()->route('evento.index')->withErrors('Erro ao criar Evento. Por favor, tente novamente.');
			else
				return redirect()->route('evento.index')->with('Evento inserida com sucesso!');
	}

	public function show($id) {
		$evento = Evento::findOrFail($id); //retorna o veículo a mostrar
		$evento->disciplina = Disciplina::find($evento->disciplina);
		$evento->documento = Curso::find($evento->curso);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($evento))
			return redirect()->route('evento.index')->withErrors('Erro ao carregar Evento. Por favor, tente novamente.');
			else
				return view('evento.item', compact('evento'));
	}

	public function edit($id) {
		$evento = Evento::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($evento)) {
			return redirect()->route('evento.index')->withErrors('Erro ao carregar evento. Por favor, tente novamente.');
		}
		else
		{


			return view('evento.edit', compact('evento'));
		}
	}

	public function update(Request $dados, $id) {
		$evento = Evento::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($evento)) {
			return redirect()->route('evento.index')->withErrors('Erro ao carregar evento. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_evento = $dados->all();
			$evento->fill($dados_evento)->save(); //atualiza os dados na BD

			return redirect()->route('evento.index')->with('flash_message', 'Evento atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$evento = Evento::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($evento)) {
			return redirect()->route('evento.index')->withErrors('Erro ao carregar evento. Por favor, tente novamente.');
		}
		else
		{
			$evento->delete(); //apaga os dados da BD

			return redirect()->route('evento.index')->with('flash_message', 'Evento apagado com sucesso!');
		}
	}
}
