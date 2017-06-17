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

class EventoController1 extends Controller
{
	public function index() {
		$eventos = Evento1::all();
		if (is_null($eventos))
			return redirect()->route("index")->withErrors('Erro ao carregar aventos. Por favor, tente mais tarde.');
			else
				return view("evento.index", compact("eventos"));

	}//


	public function create() {
		return view("evento.create");
	}

	public function store(Request $dados) {
		$evento = Evento1::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($evento))
			return redirect()->route('evento.index')->withErrors('Erro ao criar Evento. Por favor, tente novamente.');
			else
				return redirect()->route('evento.index')->with('Evento inserida com sucesso!');
	}

	public function show($id) {
		$evento = Evento1::findOrFail($id); //retorna o veículo a mostrar
		$evento->curso = Evento1::find($evento-curso);
		$evento->disciplina = Evento1::find($evento-disciplina);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($evento))
			return redirect()->route('evento.index')->withErrors('Erro ao carregar Evento. Por favor, tente novamente.');
			else
				return view('evento.item', compact('evento'));
	}

	public function edit($id) {
		$evento = Evento1::findOrFail($id); //retorna o veículo a mostrar

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
		$evento = Evento1::findOrFail($id); //retorna o veículo a mostrar

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
		$evento = Evento1::findOrFail($id); //retorna o veículo a mostrar

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
