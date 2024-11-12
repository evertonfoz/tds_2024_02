import 'dart:convert';
import 'package:http/http.dart' as http;

import '../domain/category.dart';

class CategoryDataSource {
  final String baseUrl = 'http://10.55.1.42:5001/api/categories';

  Future<List<Category>> getCategories() async {
    final response = await http.get(Uri.parse(baseUrl));
    if (response.statusCode == 200) {
      final List<dynamic> data = json.decode(response.body);
      return data.map((json) => Category.fromJson(json)).toList();
    } else {
      throw Exception('Erro ao carregar categorias');
    }
  }

  Future<Category> createCategory(Category category) async {
    final response = await http.post(
      Uri.parse(baseUrl),
      headers: {'Content-Type': 'application/json'},
      body: json.encode(category.toJson()),
    );
    if (response.statusCode == 201) {
      return Category.fromJson(json.decode(response.body));
    } else {
      throw Exception('Erro ao criar categoria');
    }
  }

  Future<void> updateCategory(Category category) async {
    final response = await http.put(
      Uri.parse('$baseUrl/${category.categoryEntityId}'),
      headers: {'Content-Type': 'application/json'},
      body: json.encode(category.toJson()),
    );
    if (response.statusCode != 200) {
      throw Exception('Erro ao atualizar categoria');
    }
  }

  Future<void> deleteCategory(int id) async {
    final response = await http.delete(Uri.parse('$baseUrl/$id'));
    if (response.statusCode != 204) {
      throw Exception('Erro ao excluir categoria');
    }
  }
}
