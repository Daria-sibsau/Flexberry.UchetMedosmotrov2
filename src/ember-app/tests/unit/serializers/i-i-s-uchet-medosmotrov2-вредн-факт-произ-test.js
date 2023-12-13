import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-uchet-medosmotrov2-вредн-факт-произ', 'Unit | Serializer | i-i-s-uchet-medosmotrov2-вредн-факт-произ', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-uchet-medosmotrov2-вредн-факт-произ',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-uchet-medosmotrov2-периодичность',
    'transform:i-i-s-uchet-medosmotrov2-пол-сотрудника',

    'model:i-i-s-uchet-medosmotrov2-вредн-факт-произ',
    'model:i-i-s-uchet-medosmotrov2-должности',
    'model:i-i-s-uchet-medosmotrov2-инд-напр-медосм',
    'model:i-i-s-uchet-medosmotrov2-класс-вред-факт',
    'model:i-i-s-uchet-medosmotrov2-контингент-сотр',
    'model:i-i-s-uchet-medosmotrov2-организация',
    'model:i-i-s-uchet-medosmotrov2-подразделения',
    'model:i-i-s-uchet-medosmotrov2-приказ-м-з-р',
    'model:i-i-s-uchet-medosmotrov2-сотрудники',
    'model:i-i-s-uchet-medosmotrov2-список-на-медосм',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
