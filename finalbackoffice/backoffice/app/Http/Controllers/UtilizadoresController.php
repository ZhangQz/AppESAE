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
  $users = Curso::find($id)->alunos()->get();
  return json_encode($users);
}
}*/

class UtilizadoresController extends Controller
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
            $response->push(['error' => 'Error creating utilizador.']);
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
                'numero' => $utilizador->ano,
                'nome' => $utilizador->nome
            ]);

        } catch (Exception $e) {
            $response->push(['error' => 'User not found.']);
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
            $response->push(['error' => 'Error updating utilizador.']);
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
            $response->push(['error' => 'Error deleting utilizador.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }
}
