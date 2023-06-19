#pragma once
#include <windows.h>

namespace AI4PorkTranscriptor {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de Interface
	/// </summary>
	public ref class Interface : public System::Windows::Forms::Form
	{
	public:
		Interface(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

		System::String^ LoadTranscription(System::String^ file_path) {
			String^ str3 = gcnew String("Hello world");

			return str3;
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~Interface()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::ComboBox^ comboBox1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;







	private: System::ComponentModel::IContainer^ components;
	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(12, 128);
			this->textBox1->Multiline = true;
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(900, 409);
			this->textBox1->TabIndex = 0;
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &Interface::textBox1_TextChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 20.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(12, 94);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(185, 31);
			this->label1->TabIndex = 1;
			this->label1->Text = L"Transcription";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(23, 22);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(142, 38);
			this->button1->TabIndex = 2;
			this->button1->Text = L"Load Audio";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Interface::button1_Click);
			// 
			// comboBox1
			// 
			this->comboBox1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(3) { L"Load audio", L"Load transcription", L"Open transcriptions folder" });
			this->comboBox1->Location = System::Drawing::Point(768, 24);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(121, 32);
			this->comboBox1->TabIndex = 3;
			this->comboBox1->Text = L"Actions";
			this->comboBox1->SelectedIndexChanged += gcnew System::EventHandler(this, &Interface::comboBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(171, 22);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(142, 38);
			this->button2->TabIndex = 4;
			this->button2->Text = L"Load Transcription";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Interface::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(319, 22);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(142, 38);
			this->button3->TabIndex = 5;
			this->button3->Text = L"Open Transcript Folder";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Interface::button3_Click);
			// 
			// Interface
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(924, 549);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->comboBox1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Name = L"Interface";
			this->Text = L"Interface";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void comboBox1_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
		ComboBox^ comboBox = (ComboBox^)(sender);
		int index = comboBox1->SelectedIndex;
		Object^ selectedItem = comboBox1->SelectedItem;

		if (index == 0)
		{
			
		}
		else if(index == 1)
		{

		}
	}

	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		String^ filep = gcnew String("Hello world");

		String^ tmp = textBox1->Text;

		if (tmp == "")
			textBox1->Text = this->LoadTranscription(filep);
		else
			textBox1->Text = "";
	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		ShellExecuteA(NULL, "open", "D:\\CodingProjects\\Cplus_Projects\\VoiceTranscriptApp\\AI4PorkTranscriptor\\AI4PorkTranscriptor", NULL, NULL, SW_SHOWDEFAULT);
	}
	private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
		system("./main -f samples/jfk.wav -otxt");
	}
};
}
