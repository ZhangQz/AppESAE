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

class CursoController1 extends Controller
{
	public function index() {
		$cursos = Curso::all();
		if (is_null($cursos))
			return redirect()->route("index")->withErrors('Erro ao carregar cursos. Por favor, tente mais tarde.');
			else
				return view("curso.index", compact("cursos"));

	}//


	public function create() {
		return view("curso.create");
	}

	public function store(Request $dados) {
		$curso = Curso::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($curso))
			return redirect()->route('curso.index')->withErrors('Erro ao criar curso. Por favor, tente novamente.');
			else
				return redirect()->route('curso.index')->with('Curso inserida com sucesso!');
	}

	public function show($id) {
		$curso = Curso::findOrFail($id); //retorna o veículo a mostrar
		$curso->disciplina = Disciplina::find($curso->disciplina);
		$curso->documento = Documento::find($curso->documento);
		$curso->evento = Evento::find($curso->evento);
		$curso->propina = Propina::find($curso->propina);
		$curso->utilizador = Utilizador::find($curso->utilizador);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($curso))
			return redirect()->route('curso.index')->withErrors('Erro ao carregar Curso. Por favor, tente novamente.');
			else
				return view('curso.item', compact('curso'));
	}
	
	
	
	public function edit($id) {
		$curso = Curso::findOrFail($id); //retorna o veículo a mostrar

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
		$curso = Curso::findOrFail($id); //retorna o veículo a mostrar

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
		$curso = Curso::findOrFail($id); //retorna o veículo a mostrar

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
