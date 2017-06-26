<?php

namespace App\Http\Controllers;

//interfaces
use Illuminate\Support\collection;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
//use Illuminate\Support\Facades\Input;

//models
use App\Utilizador;
use App\Curso;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;
use App\Propina;


/*
function listByCourse($id) {
  $paper = Curso::find($id)->docs()->get();
  return json_encode($paper);
}
}*/

class DocumentosController extends Controller
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

            $documento = Documento::create();
            $response->push(['created' => 'Documento created successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error creating documento.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }

    public function show($id) {
        try {
            $statusCode = 200;
            $response = collect([]);

            $documento = Documento::findOrFail($id);

            $response->push([
                'id' => $documento->id,
                'nome' => $documento->nome,
                'categoria' => $documento->categoria
            ]);

        } catch (Exception $e) {
            $response->push(['error' => 'Documento not found.']);
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
            $response->push(['error' => 'Error updating documento.']);
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
            $response->push(['error' => 'Error deleting documento.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }
}
