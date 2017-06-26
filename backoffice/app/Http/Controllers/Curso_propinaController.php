<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\Redirect;
use App\Curso_propina;


class Curso_propinaController extends Controller
{
	public function index() {
		$curso_propinas = Curso_propina::all();
		if (is_null($curso_propinas))
			return redirect()->route("index")->withErrors('Erro ao carregar utilizadores. Por favor, tente mais tarde.');
			else
				return view("curso_propina.index", compact("curso_propinas"));
				
	}//
	
	
	public function create() {
		return view("curso_propina.create");
	}
	
	public function store(Request $dados) {
		$curso_propina =  Curso_propina::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)
		
		//verifica se o veículo foi criado com sucesso
		if(is_null($curso_propina))
			return redirect()->route('curso_propina.index')->withErrors('Erro ao criar utilizador. Por favor, tente novamente.');
			else
				return redirect()->route('curso_propina.index')->with('Utilizador inserida com sucesso!');
	}
	
	public function show($id) {
		$utilizador =  Curso_propina::findOrFail($id); //retorna o veículo a mostrar
		$utilizador->curso =  Curso_propina::find($utilizador-curso);
		
		//verifica se o veículo foi preenchido com sucesso
		if (is_null($utilizador))
			return redirect()->route('utilizador.index')->withErrors('Erro ao carregar Utilizador. Por favor, tente novamente.');
			else
				return view('utilizador.item', compact('utilizador'));
	}
	
	public function edit($id) {
		$utilizador =  Curso_propina::findOrFail($id); //retorna o veículo a mostrar
		
		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($utilizador)) {
			return redirect()->route('utilizador.index')->withErrors('Erro ao carregar utilizador. Por favor, tente novamente.');
		}
		else
		{
			
			
			return view('utilizador.edit', compact('utilizador'));
		}
	}
	
	public function update(Request $dados, $id) {
		$utilizador =  Curso_propina::findOrFail($id); //retorna o veículo a mostrar
		
		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($utilizador)) {
			return redirect()->route('utilizador.index')->withErrors('Erro ao carregar utilizador. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_utilizador = $dados->all();
			$utilizador->fill($dados_utilizador)->save(); //atualiza os dados na BD
			
			return redirect()->route('utilizador.index')->with('flash_message', 'Utilizador atualizada com sucesso!');
		}
	}
	public function destroy($id) {
		$utilizador =  Curso_propina::findOrFail($id); //retorna o veículo a mostrar
		
		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($utilizador)) {
			return redirect()->route('utilizador.index')->withErrors('Erro ao carregar utilizador. Por favor, tente novamente.');
		}
		else
		{
			$utilizador->delete(); //apaga os dados da BD
			
			return redirect()->route('utilizador.index')->with('flash_message', 'Utilizador apagado com sucesso!');
		}
	}
}