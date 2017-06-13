<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
use App\Documento;

class DocumentoController extends Controller
{
	public function index() {
		try {
			$statusCode = 200; //Ok
			
			//reset data collection
			$response = collect([]);
			
			//get all friends from database
			$documentos = Documento::all();
			
			foreach($documentos as $documento)
			{
				//add friend to the collection
				$response->push([
						'id' => $documento->id,
						'nome' => $documento->nome,
						'categoria' => $documento->categoria
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
			
			$curso = Curso::create();
			$response->push(['created' => 'Curso created successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error creating Curso.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function show($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$curso = Curso::findOrFail($id);
			$response->push([
					'id' => $documento->id,
					'nome' => $documento->nome,
					'categoria' => $documento->categoria
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
			
			$documento = Documento::findOrFail($id);
			$documento->fill($dados->all())->save();
			$response->push(['updated' => 'Documento updated successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error updating Documento.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
	
	public function destroy($id) {
		try {
			$statusCode = 200;
			$response = collect([]);
			
			$documento = Documento::findOrFail($id);
			$documento->delete();
			$response->push(['success' => 'Documento deleted successfully.']);
		} catch (Exception $e) {
			$response->push(['error' => 'Error deleting Documento.']);
			$statusCode = 404;
		} finally {
			return response()->json($response, $statusCode);
		}
	}
}
