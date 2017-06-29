<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Curso;
use App\Utilizador;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;
use App\Propina;

class UsersController1 extends Controller
{
  public function index() {
		$users = User::all();
		if (is_null($users))
			return redirect()->route("index")->withErrors('Erro ao carregar user. Por favor, tente mais tarde.');
			else
				return view("user.index", compact("users"));

	}//


	public function create() {
		return view("user.create");
	}

	public function store(Request $dados) {
		$user = Utilizador::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)

		//verifica se o veículo foi criado com sucesso
		if(is_null($user))
			return redirect()->route('user.index')->withErrors('Erro ao criar user. Por favor, tente novamente.');
			else
				return redirect()->route('user.index')->with('User inserida com sucesso!');
	}

	public function show($id) {
		$user = Utilizador::findOrFail($id); //retorna o veículo a mostrar
		$user->utilizador = User1::find($user-utilizador);

		//verifica se o veículo foi preenchido com sucesso
		if (is_null($user))
			return redirect()->route('user.index')->withErrors('Erro ao carregar user. Por favor, tente novamente.');
			else
				return view('user.item', compact('user'));
	}

	public function edit($id) {
		$user = User::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($user)) {
			return redirect()->route('user.index')->withErrors('Erro ao carregar user. Por favor, tente novamente.');
		}
		else
		{


			return view('user.edit', compact('user'));
		}
	}

	public function update(Request $dados, $id) {
		$user = User::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($user)) {
			return redirect()->route('user.index')->withErrors('Erro ao carregar user. Por favor, tente novamente.');
		}
		else
		{
			$this->validate($dados, ['id' => 'required']); //validações
			$dados_user = $dados->all();
			$user->fill($dados_user)->save(); //atualiza os dados na BD

			return redirect()->route('user.index')->with('flash_message', 'User atualizado com sucesso!');
		}
	}
	public function destroy($id) {
		$user = User::findOrFail($id); //retorna o veículo a mostrar

		//verificar se o veículo existe (em caso negativo, envia um erro para a view)
		if (is_null($user)) {
			return redirect()->route('user.index')->withErrors('Erro ao carregar user. Por favor, tente novamente.');
		}
		else
		{
			$user->delete(); //apaga os dados da BD

			return redirect()->route('user.index')->with('flash_message', 'User apagado com sucesso!');
		}
	}
}
