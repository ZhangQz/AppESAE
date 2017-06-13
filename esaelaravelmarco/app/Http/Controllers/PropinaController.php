<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use App\Propina;

class PropinaController extends Controller
{
	public function index() {
		try {
			$statusCode = 200; //Ok
			
			//reset data collection
			$response = collect([]);
			
			//get all friends from database
			$propinas = Propina::all();
			
			foreach($propinas as $propina)
			{
				//add friend to the collection
				$response->push([
						'id' => $propina->id,
						'ano' => $propina->ano,
						'mes' => $propina->mes,
						'valor' => $propina->valor,
						'pago' => $propina->pago
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
			
			$propina = Propina::create();
			$response->push(['created' => 'Propina created successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error creating Propina.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function show($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$propina = Propina::findOrFail($id);
			$response->push([
					'id' => $propina->id,
					'ano' => $propina->ano,
					'mes' => $propina->mes,
					'valor' => $propina->valor,
					'pago' => $propina->pago
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
			
			$propina = Propina::findOrFail($id);
			$propina->fill($dados->all())->save();
			$response->push(['updated' => 'Propina updated successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error updating Propina.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function destroy($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$propina = Propina::findOrFail($id);
			$propina->delete();
			$response->push(['success' => 'Propina deleted successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error deleting Propina.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
}