<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Input;
use Illuminate\Support\Facades\Redirect;
use App\Maquina;

class MaquinaController extends Controller
{
 public function index() {
    $maquinas = Maquina::all(); 
        if (is_null($maquinas))
            return redirect()->route("index")->withErrors('Erro ao carregar maquinas. Por favor, tente mais tarde.');
        else
           return view("maquina.index", compact("maquinas"));
    
    }//
    
    
    public function create() {
    return view("maquina.create");
    }
    
    public function store(Request $dados) {
    	$maquina = Maquina::create($dados->all()); //cria o veículo com os dados do formulário (utilizei a facade Request)
    
    	//verifica se o veículo foi criado com sucesso
    	if(is_null($maquina))
    		return redirect()->route('maquina.index')->withErrors('Erro ao criar maquina. Por favor, tente novamente.');
    	else
    		return redirect()->route('maquina.index')->with('Maquina inserida com sucesso!');
    }
    
    public function show($id) {
    	$maquina = Maquina::findOrFail($id); //retorna o veículo a mostrar
    	$maquina->plano = Maquina::find($maquina-plano);
    
    	//verifica se o veículo foi preenchido com sucesso
    	if (is_null($maquina))
    		return redirect()->route('maquina.index')->withErrors('Erro ao carregar Maquina. Por favor, tente novamente.');
    	else
    		return view('maquina.item', compact('maquina'));
    }
    
    public function edit($id) {
    	$maquina = Maquina::findOrFail($id); //retorna o veículo a mostrar
    
    	//verificar se o veículo existe (em caso negativo, envia um erro para a view)
    	if (is_null($maquina)) {
    		return redirect()->route('maquina.index')->withErrors('Erro ao carregar maquina. Por favor, tente novamente.');
    	}
    	else
    	{
    
    
    		return view('maquina.edit', compact('maquina'));
    	}
    }
    
    public function update(Request $dados, $id) {
    	$maquina = Maquina::findOrFail($id); //retorna o veículo a mostrar
    
    	//verificar se o veículo existe (em caso negativo, envia um erro para a view)
    	if (is_null($maquina)) {
    		return redirect()->route('maquina.index')->withErrors('Erro ao carregar maquina. Por favor, tente novamente.');
    	}
    	else
    	{
    		$this->validate($dados, ['nome' => 'required']); //validações
    		$dados_maquina = $dados->all();
    		$maquina->fill($dados_maquina)->save(); //atualiza os dados na BD
    
    		return redirect()->route('maquina.index')->with('flash_message', 'Maquina atualizada com sucesso!');
    	}
    }
    public function destroy($id) {
    	$maquina = Maquina::findOrFail($id); //retorna o veículo a mostrar
    
    	//verificar se o veículo existe (em caso negativo, envia um erro para a view)
    	if (is_null($maquina)) {
    		return redirect()->route('maquina.index')->withErrors('Erro ao carregar maquina. Por favor, tente novamente.');
    	}
    	else
    	{
    		$maquina->delete(); //apaga os dados da BD
    
    		return redirect()->route('maquina.index')->with('flash_message', 'Maquina apagado com sucesso!');
    	}
    }
}
