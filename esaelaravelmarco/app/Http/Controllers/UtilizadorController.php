<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use App\Utilizador;

class UtilizadorController extends Controller
{
	public function index() {
		try {
			$statusCode = 200; //Ok
			
			//reset data collection
			$response = collect([]);
			
			//get all friends from database
			$utilizadores = Utilizador::all();
			
			foreach($utilizadores as $utilizador)
			{
				//add friend to the collection
				$response->push([
						'id' => $utilizador->id,
						'numero' => $utilizador->numero,
						'nome' => $utilizador->nome
				]);
			}
		} catch (Exception $e) {
			$statusCode = 400; //bad request
		} finally {
			return response()->json($response, $statusCode)->header('Access-Control-Allow-Origin', '*')->header('Access-Control-Allow-Methods', 'GET,POST,PUT,DELETE,OPTIONS');
		}
	}
	
	public function store(Request $dados) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$utilizador = Utilizador::create();
			$response->push(['created' => 'Utilizador created successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error creating Utilizador.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function show($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$utilizador = Utilizador::findOrFail($id);
			$response->push([
					'id' => $utilizador->id,
					'numero' => $utilizador->numero,
					'nome' => $utilizador->nome
			]);
		} catch (Exception $e) {
			$response->push(['error' => 'Curso not found.']);
			$statusCode = 404; //Not Found
		} finally {
			return response()->json($response, $statusCode)->header('Access-Control-Allow-Origin', '*')->header('Access-Control-Allow-Methods', 'GET,POST,PUT,DELETE,OPTIONS');
		}
	}
	
	public function update(Request $dados, $id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$utilizador = Utilizador::findOrFail($id);
			$utilizador->fill($dados->all())->save();
			$response->push(['updated' => 'Utilizador updated successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error updating Utilizador.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function destroy($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$utilizador = Utilizador::findOrFail($id);
			$utilizador->delete();
			$response->push(['success' => 'Utilizador deleted successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error deleting Utilizador.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
}