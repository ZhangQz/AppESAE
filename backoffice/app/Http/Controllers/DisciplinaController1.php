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

class DisciplinaController1 extends Controller
{
	public function index() {
		$disciplinas = Disciplina1::all();
		if (is_null($disciplinas))
			return redirect()->route("index")->withErrors('Erro ao carregar disciplinas. Por favor, tente mais tarde.');
			else
				return view("disciplina.index", compact("disciplinas"));

	}//


	public function create() {
		return view("disciplina.create");
	}

	public function store(Request $dados) {
		$disciplina = Disciplina1::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($disciplina))
			return redirect()->route('disciplina.index')->withErrors('Erro ao criar disciplina. Por favor, tente novamente.');
			else
				return redirect()->route('disciplina.index')->with('Disciplina inserida com sucesso!');
	}

	public function show($id) {
		$disciplina = Disciplina1::findOrFail($id); //retorna o veículo a mostrar
		$disciplina->curso = Disciplina1::find($disciplina-curso);
		$disciplina->evento = Disciplina1::find($disciplina-evento);
		//verifica se o veículo foi preenchido com sucesso
		if (is_null($disciplina))
			return redirect()->route('disciplina.index')->withErrors('Erro ao carregar Disciplina. Por favor, tente novamente.');
			else
				return view('disciplina.item', compact('disciplina'));
	}

	public function edit($id) {
		$disciplina = Disciplina1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($disciplina)) {
			return redirect()->route('disciplina.index')->withErrors('Erro ao carregar disciplina. Por favor, tente novamente.');
		}
		else
		{


			return view('disciplina.edit', compact('disciplina'));
		}
	}

	public function update(Request $dados, $id) {
		$disciplina = Disciplina1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($disciplina)) {
			return redirect()->route('disciplina.index')->withErrors('Erro ao carregar disciplina. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_disciplina = $dados->all();
			$disciplina->fill($dados_disciplina)->save(); //atualiza os dados na BD

			return redirect()->route('disciplina.index')->with('flash_message', 'Disciplina atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$disciplina = Disciplina1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($disciplina)) {
			return redirect()->route('disciplina.index')->withErrors('Erro ao carregar disciplina. Por favor, tente novamente.');
		}
		else
		{
			$disciplina->delete(); //apaga os dados da BD

			return redirect()->route('disciplina.index')->with('flash_message', 'Disciplina apagada com sucesso!');
		}
	}
}
