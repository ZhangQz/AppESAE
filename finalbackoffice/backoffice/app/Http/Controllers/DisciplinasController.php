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
    $disci = Curso::find($id)->unidades()->get();
    return json_encode($disci);
  }
}*/

class DisciplinasController extends Controller
{
    public function index() {
        try {
            $statusCode = 200; //Ok

            //reset data collection
            $response = collect([]);

            //get all friends from database
            $disciplinas = Disciplina::all();

            foreach($disciplinas as $disciplina)
            {
                //add friend to the collection
                $response->push([
                    'id' => $disciplina->id,
                    'nome' => $disciplina->nome
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

            $disciplina = Disciplina::create();
            $response->push(['created' => 'Disciplina created successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error creating disciplina.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }

    public function show($id) {
        try {
            $statusCode = 200;
            $response = collect([]);

            $disciplina = Disciplina::findOrFail($id);

            $response->push([
                'id' => $curso->id,
                'nome' => $curso->nome
            ]);

        } catch (Exception $e) {
            $response->push(['error' => 'Disciplina not found.']);
            $statusCode = 404; //Not Found
        } finally {
            return response()->json($response, $statusCode)->header('Access-Control-Allow-Origin', '*')->header('Access-Control-Allow-Methods', 'GET,POST,PUT,DELETE,OPTIONS');
        }
    }

    public function update(Request $dados, $id) {
        try {
            $statusCode = 200;
            $response = collect([]);

            $disciplina = Disciplina::findOrFail($id);
            $disciplina->fill($dados->all())->save();
            $response->push(['updated' => 'Disciplina updated successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error updating disciplina.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }

    public function destroy($id) {
        try {
            $statusCode = 200;
            $response = collect([]);

            $disciplina = Disciplina::findOrFail($id);
            $disciplina->delete();
            $response->push(['success' => 'Disciplina deleted successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error deleting disciplina.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }
}
