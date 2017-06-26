<?php

namespace App\Http\Controllers;

//interfaces
use Illuminate\Support\collection;
use Illuminate\Http\Request;
use Illuminate\Http\Response;
//use Illuminate\Support\Facades\Input;

//models
use App\Curso;
use App\Utilizador;
use App\Disciplina;
use App\Documento;
use App\Evento;
use App\User;
use App\Propina;

class CursosController extends Controller
{
    public function index() {
        try {
            $statusCode = 200; //Ok

            //reset data collection
            $response = collect([]);

            //get all friends from database
            $cursos = Curso::all();

            foreach($cursos as $curso)
            {
                //add friend to the collection
                $response->push([
                    'id' => $curso->id,
                    'nome' => $curso->nome,
                    'tipodecurso' => $curso->tipodecurso,
                    'responsavel' => $curso->responsavel,
                    'descricao' => $curso->descricao,
                    'email' => $curso->email,
                    'telefone' => $curso->telefone
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
                'id' => $curso->id,
                'nome' => $curso->nome,
                'tipodecurso' => $curso->tipodecurso,
                'responsavel' => $curso->responsavel,
                'descricao' => $curso->descricao,
                'email' => $curso->email,
                'telefone' => $curso->telefone
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

            $curso = Friend::findOrFail($id);
            $curso->fill($dados->all())->save();
            $response->push(['updated' => 'Curso updated successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error updating curso.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }

    public function destroy($id) {
        try {
            $statusCode = 200;
            $response = collect([]);

            $curso = Curso::findOrFail($id);
            $curso->delete();
            $response->push(['success' => 'Curso deleted successfully.']);
        } catch (Exception $e) {
            $response->push(['error' => 'Error deleting curso.']);
            $statusCode = 404;
        } finally {
            return response()->json($response, $statusCode);
        }
    }
}
