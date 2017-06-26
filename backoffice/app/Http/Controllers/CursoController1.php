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

class CursoController1 extends Controller
{
	public function index() {
		$cursos = Curso1::all();
		if (is_null($cursos))
			return redirect()->route("index")->withErrors('Erro ao carregar cursos. Por favor, tente mais tarde.');
			else
				return view("curso.index", compact("cursos"));

	}//


	public function create() {
		return view("curso.create");
	}

	public function store(Request $dados) {
		$curso = Curso1::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($curso))
			return redirect()->route('curso.index')->withErrors('Erro ao criar curso. Por favor, tente novamente.');
			else
				return redirect()->route('curso.index')->with('Curso inserida com sucesso!');
	}

	public function show($id) {
		$curso = Curso1::findOrFail($id); //retorna o veículo a mostrar
		$curso->disciplina = Curso1::find($curso-disciplina);
		$curso->documento = Curso1::find($curso-documento);
		$curso->evento = Curso1::find($curso-evento);
		$curso->propina = Curso1::find($curso-propina);
		$curso->utilizador = Curso1::find($curso-utilizador);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($maquina))
			return redirect()->route('curso.index')->withErrors('Erro ao carregar Curso. Por favor, tente novamente.');
			else
				return view('curso.item', compact('curso'));
	}

	public function edit($id) {
		$curso = Curso1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($curso)) {
			return redirect()->route('curso.index')->withErrors('Erro ao carregar curso. Por favor, tente novamente.');
		}
		else
		{


			return view('curso.edit', compact('curso'));
		}
	}

	public function update(Request $dados, $id) {
		$curso = Curso1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($curso)) {
			return redirect()->route('curso.index')->withErrors('Erro ao carregar maquina. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_curso = $dados->all();
			$curso->fill($dados_curso)->save(); //atualiza os dados na BD

			return redirect()->route('curso.index')->with('flash_message', 'Curso atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$curso = Curso1::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($curso)) {
			return redirect()->route('curso.index')->withErrors('Erro ao carregar curso. Por favor, tente novamente.');
		}
		else
		{
			$curso->delete(); //apaga os dados da BD

			return redirect()->route('curso.index')->with('flash_message', 'Curso apagado com sucesso!');
		}
	}
}
