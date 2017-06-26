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
use App\Propina;
use App\User;
use App\Propina;


/*
function show($id) {
  $money = Propina::find($id);
  return json_encode($money);
}

function listByCourse($id) {
  $money = Curso::find($id)->money()->get();
  return json_encode($money);
}
}*/

class PropinasController extends Controller
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
            $response->push(['error' => 'Error creating propina.']);
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
            $response->push(['error' => 'Propina not found.']);
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
            $response->push(['error' => 'Error updating propina.']);
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
            $response->push(['error' => 'Error deleting propina.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }
}
